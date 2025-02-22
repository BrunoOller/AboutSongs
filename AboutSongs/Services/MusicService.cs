using AboutSongs.Data;
using AboutSongs.Models;
using AboutSongs.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace AboutSongs.Services;

public class MusicService : IMusicService
{
    private readonly AppDbContext _db;

    public MusicService(AppDbContext db)
    {
        _db = db;
    }

    public List<AlbumVM> GetAlbuns()
    {
        return _db.Albuns
            .AsNoTracking()
            .Include(aa => aa.Artistas)
                .ThenInclude(aa => aa.Artista)
            .Include(aa => aa.Artistas)
                .ThenInclude(aa => aa.Musica)
                .ThenInclude(m => m.Generos)
                .ThenInclude(mg => mg.Genero)
            .AsEnumerable()
            .Select(item => new AlbumVM
            {
                Id = item.Id,
                Nome = item.Nome ?? item.Titulo,
                Foto = item.Foto,
                Musicas = item.Artistas
                    .Select(a => a.Musica)
                    .Distinct()
                    .ToList(),
                Artistas = item.Artistas
                    .Select(a => a.Artista)
                    .DistinctBy(a => a.Id)
                    .ToList(),
                Generos = item.Artistas
                    .SelectMany(a => a.Musica.Generos)
                    .Select(mg => mg.Genero)
                    .DistinctBy(mg => mg.Id)
                    .ToList()
            }).ToList();
    }

    public AlbumVM GetAlbum(int id)
    {
        return _db.Albuns
            .AsNoTracking()
            .Where(a => a.Id == id)
            .Include(aa => aa.Artistas)
                .ThenInclude(aa => aa.Artista)
            .Include(aa => aa.Artistas)
                .ThenInclude(aa => aa.Musica)
                .ThenInclude(m => m.Generos)
                .ThenInclude(mg => mg.Genero)
            .Include(m => m.Comentarios)
                .ThenInclude(mc => mc.Usuario)
            .AsEnumerable()
            .Select(item => new AlbumVM
            {
                Id = item.Id,
                Nome = item.Nome ?? item.Titulo,
                Foto = item.Foto,
                Comentarios = item.Comentarios.ToList(),
                Musicas = item.Artistas
                    .Select(a => a.Musica)
                    .Distinct()
                    .ToList(),
                Artistas = item.Artistas
                    .Select(a => a.Artista)
                    .DistinctBy(a => a.Id)
                    .ToList(),
                Generos = item.Artistas
                    .SelectMany(a => a.Musica.Generos)
                    .Select(mg => mg.Genero)
                    .DistinctBy(mg => mg.Id)
                    .ToList()
            })
            .SingleOrDefault();
    }

    public List<MusicaVM> GetMusicas()
    {
        return _db.Musicas
            .AsNoTracking()
            .Include(aa => aa.AlbunsArtistas)
                .ThenInclude(aa => aa.Artista)
            .Include(aa => aa.AlbunsArtistas)
                .ThenInclude(aa => aa.Album)
            .Include(m => m.Generos)
                .ThenInclude(mg => mg.Genero)
            .AsEnumerable()
            .Select(item => new MusicaVM
            {
                Id = item.Id,
                Nome = item.Título,
                Foto = item.AlbunsArtistas.First().Album.Foto,
                Spotify= item.Spotify,
                Youtube = item.Youtube,
                AppleMusic = item.AppleMusic,
                Albuns = item.AlbunsArtistas
                    .Select(a => a.Album)
                    .Distinct()
                    .ToList(),
                Artistas = item.AlbunsArtistas
                    .Select(a => a.Artista)
                    .DistinctBy(a => a.Id)
                    .ToList(),
                Generos = item.Generos
                    .Select(mg => mg.Genero)
                    .DistinctBy(mg => mg.Id)
                    .ToList()
            }).ToList();
    }

    public MusicaVM GetMusica(int id)
    {
        return _db.Musicas
            .AsNoTracking()
            .Where(m => m.Id == id)
            .Include(aa => aa.AlbunsArtistas)
                .ThenInclude(aa => aa.Artista)
            .Include(aa => aa.AlbunsArtistas)
                .ThenInclude(aa => aa.Album)
            .Include(m => m.Generos)
                .ThenInclude(mg => mg.Genero)
            .Include(m => m.Comentarios)
                .ThenInclude(mc => mc.Usuario)
            .AsEnumerable()
            .Select(item => new MusicaVM
            {
                Id = item.Id,
                Nome = item.Título,
                Foto = item.AlbunsArtistas.First().Album.Foto,
                Spotify= item.Spotify,
                Youtube = item.Youtube,
                AppleMusic = item.AppleMusic,
                Comentarios = item.Comentarios.ToList(),
                Albuns = item.AlbunsArtistas
                    .Select(a => a.Album)
                    .Distinct()
                    .ToList(),
                Artistas = item.AlbunsArtistas
                    .Select(a => a.Artista)
                    .DistinctBy(a => a.Id)
                    .ToList(),
                Generos = item.Generos
                    .Select(mg => mg.Genero)
                    .DistinctBy(mg => mg.Id)
                    .ToList()
            })
            .SingleOrDefault();
    }


}

