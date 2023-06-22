using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[Controller]")]
public class UsuarioController : ControllerBase
{
    private CadastroService _cadastroService;

    public UsuarioController(CadastroService cadastroService)
    {
       _cadastroService = cadastroService;
    }

    [HttpPost]
    public async Task<IActionResult> CadastraUsuario(CreateUsuarioDtos dto)
    {
        await _cadastroService.Cadastro(dto);

        return Ok("Usuario Cadastrado");
        
    }
}