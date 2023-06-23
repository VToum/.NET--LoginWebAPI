using AutoMapper;
using LoginAPI.Data.Dtos;
using Microsoft.AspNetCore.Identity;

public class CadastroService
{
    private IMapper _mapper;
    private UserManager<Usuario> _userManager;
    private SignInManager<Usuario> _signInManager;

    public CadastroService(IMapper mapper, UserManager<Usuario> userManager, SignInManager<Usuario> signInManager)
    {
        _mapper = mapper;
        _userManager = userManager;
        _signInManager = signInManager;
    }

    public async Task Cadastro(CreateUsuarioDtos dto)
    {
        Usuario usuario = _mapper.Map<Usuario>(dto);
        IdentityResult resultado = await _userManager.CreateAsync(usuario, dto.Password);

        if (!resultado.Succeeded)
        {
            throw new ApplicationException("Falha ao cadastrar");

        }

    }

    public async Task LoginUsuario(LoginUsuarioDto dto)
    {
        var resultado = await _signInManager.PasswordSignInAsync(dto.UserName, dto.Password, false, false);

        if (!resultado.Succeeded)
        {

            throw new NotImplementedException("Falha ao Autenticar");
        }

    }
}