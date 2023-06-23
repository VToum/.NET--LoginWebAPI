using AutoMapper;
using LoginAPI.Data.Dtos;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[Controller]")]
public class UsuarioController : ControllerBase
{
    private CadastroService _usuarioService;

    public UsuarioController(CadastroService cadastroService)
    {
        _usuarioService = cadastroService;
    }

    [HttpPost("cadastro")]
    public async Task<IActionResult> Cadastra(CreateUsuarioDtos dto)
    {
        await _usuarioService.Cadastro(dto);

        return Ok("Usuario Cadastrado");
        
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginUsuarioDto dto)
    {
        await _usuarioService.LoginUsuario(dto);
        return Ok("Usuario Autenticado!");
    }
}