using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AboutSongs.Models;
using AboutSongs.Data;
using AboutSongs.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using AboutSongs.Services;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security.Claims;


namespace AboutSongs.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;
    private readonly IMusicService _musicService;
    private readonly IUsuarioService _usuarioService;

    public HomeController(ILogger<HomeController> logger, AppDbContext context, IMusicService musicService, IUsuarioService usuarioService)
    {
        _logger = logger;
        _context = context;
        _musicService = musicService;
        _usuarioService = usuarioService;
    }

    public IActionResult Index()
    {
        var musicas = _musicService.GetMusicas();
        var musicasFiltradas = musicas.GroupBy(musica => musica.Albuns.FirstOrDefault()?.Id).Select(grupo => grupo.First());
        HomeVM homeVM = new()
        {
            Albuns = _musicService.GetAlbuns(),
            Musicas = musicasFiltradas.ToList()
        };
        return View(homeVM);
    }

    public IActionResult Albuns()
    {
        var albuns = _musicService.GetAlbuns();
        return View(albuns);
    }

    [HttpGet]
    public IActionResult BuscarAlbuns(string genero, string termo)
    {
        var albuns = _musicService.GetAlbuns();

        // Filtro por gênero
        if (!string.IsNullOrEmpty(genero))
        {
            albuns = albuns.Where(a =>
                a.Generos.Any(g => g.Nome.Equals(genero, StringComparison.OrdinalIgnoreCase))
            ).ToList();
        }

        // Filtro por termo de pesquisa
        if (!string.IsNullOrEmpty(termo))
        {
            albuns = albuns.Where(a =>
                a.Nome.Contains(termo, StringComparison.OrdinalIgnoreCase)
            ).ToList();
        }

        return PartialView("_AlbunsList", albuns);
    }

    public IActionResult Album(int id)
    {
        AlbumVM album = _musicService.GetAlbum(id);
        return View(album);
    }

    public IActionResult Musica(int id)
    {
        MusicaVM musica = _musicService.GetMusica(id);
        return View(musica);
    }

    public IActionResult Musicas()
    {
        var musicas = _musicService.GetMusicas();
        return View(musicas);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> ComentarMusica(ComentarioVM comenta)
    {
        if (ModelState.IsValid)
        {
            var usuario = await _usuarioService.GetUsuarioLogado();
            ComentarioMusica comentarioMusica = new()
            {
                MusicaId = comenta.Id,
                DataDePublicacao = DateTime.Now,
                UsuarioId = usuario.UsuarioId,
                Comentario = comenta.Comentario
            };
            await _context.ComentarioMusicas.AddAsync(comentarioMusica);
            await _context.SaveChangesAsync();
            return RedirectToAction("Musica", "Home", new { comenta.Id });
        }
        return RedirectToAction("Musicas");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> ComentarAlbum(ComentarioVM comenta)
    {
        if (ModelState.IsValid)
        {
            var usuario = await _usuarioService.GetUsuarioLogado();
            ComentarioAlbum comentarioAlbum = new()
            {
                AlbumId = comenta.Id,
                DataDePublicacao = DateTime.Now,
                UsuarioId = usuario.UsuarioId,
                Comentario = comenta.Comentario
            };
            await _context.ComentarioAlbuns.AddAsync(comentarioAlbum);
            await _context.SaveChangesAsync();
            return RedirectToAction("Album", "Home", new { comenta.Id });
        }
        return RedirectToAction("Albuns");
    }
    
    [HttpGet]
    public IActionResult BuscarMusicas(string genero, string termo)
    {
        var musicas = _musicService.GetMusicas();

        // Filtro por gênero
        if (!string.IsNullOrEmpty(genero))
        {
            musicas = musicas.Where(m =>
                m.Generos.Any(g => g.Nome.Equals(genero, StringComparison.OrdinalIgnoreCase))
            ).ToList();
        }

        // Filtro por termo de pesquisa
        if (!string.IsNullOrEmpty(termo))
        {
            musicas = musicas.Where(m =>
                m.Nome.Contains(termo, StringComparison.OrdinalIgnoreCase)
            ).ToList();
        }

        return PartialView("_MusicasList", musicas);
    }

    public IActionResult Perfil()
    {
        var usuarioId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var usuario = _context.Usuarios.Find(usuarioId);
        if (usuario == null)
            return RedirectToAction("Login", "Account");

        if (usuario == null)
        {
            return NotFound();
        }
        return View(usuario);
    }

    [HttpPost]
    public async Task<IActionResult> EditarPerfil(Usuario usuario, IFormFile foto)
    {
        if (ModelState.IsValid)
        {
            var usuarioId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var usuarioExistente = await _context.Usuarios.FindAsync(usuarioId);
            if (usuarioExistente == null)
                return RedirectToAction("Login", "Account");

            if (usuarioExistente != null)
            {
                usuarioExistente.Nome = usuario.Nome;
                usuarioExistente.Foto = usuario.Foto;

                if (foto != null && foto.Length > 0)
                {
                    var caminhoDiretorio = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "img", "usuarios");

                    if (!Directory.Exists(caminhoDiretorio))
                    {
                        Directory.CreateDirectory(caminhoDiretorio);
                    }

                    var filePath = Path.Combine(caminhoDiretorio, foto.FileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await foto.CopyToAsync(stream);
                    }

                    usuarioExistente.Foto = $"/img/usuarios/{foto.FileName}";
                }

                await _context.SaveChangesAsync();
                return RedirectToAction("Perfil");
            }
        }

        return View(usuario);
    }

    public IActionResult Sobre()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}