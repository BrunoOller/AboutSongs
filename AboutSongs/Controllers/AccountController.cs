using System.Net.Mail;
using System.Security.Claims;
using System.Security.Policy;
using AboutSongs.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using AboutSongs.Services;


namespace AboutSongs.Controllers;
public class AccountController : Controller
{
    private readonly ILogger<AccountController> _logger;
    private readonly IUsuarioService _usuarioService;

    public AccountController(ILogger<AccountController> logger, IUsuarioService usuarioService)
    {
        _logger = logger;
        _usuarioService = usuarioService;
    }

    [HttpGet]
    public IActionResult Login(string returnUrl)
    {
        LoginVM login = new()
        {
            UrlRetorno = returnUrl ?? Url.Content("~/")
        };
        return View(login);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(LoginVM login)
    {
        if (ModelState.IsValid)
        {
            var result = await _usuarioService.LoginUsuario(login);
            if (result.Succeeded)
                return LocalRedirect(login.UrlRetorno);
            if (result.IsLockedOut)
                return RedirectToAction("Lockout");
            if (result.IsNotAllowed)
                ModelState.AddModelError(string.Empty, "Sua conta não está confirmada, verifique seu email!!");
            else
                ModelState.AddModelError(string.Empty, "Usuário e/ou Senha Inválidos!!!");
        }
        return View(login);
    }

    [HttpGet]
    public IActionResult Registro()
    {
        RegistroVM register = new();
        return View(register);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Registro(RegistroVM register)
    {
        register.Enviado = false;
        if (ModelState.IsValid)
        {
            var result = await _usuarioService.RegistrarUsuario(register);
            if (result != null)
                foreach (var error in result)
                {
                    ModelState.AddModelError(string.Empty, error);
                }
            register.Enviado = result == null;
        }
        return View(register);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Logout()
    {
        await _usuarioService.LogoffUsuario();
        return RedirectToAction("Index", "Home");
    }

    public IActionResult AcessDenied()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View();
    }
}