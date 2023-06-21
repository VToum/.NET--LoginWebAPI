using AutoMapper;

public class UsuarioProfile : Profile
{
    public UsuarioProfile()
    {
        CreateMap<CreateUsuarioDtos, Usuario>();   
    }
}