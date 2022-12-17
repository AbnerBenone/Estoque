using AB.Estoque.Application.ViewModel.Cliente;
using AB.Estoque.Domain.Models;
using AutoMapper;

namespace AB.Estoque.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Clientes, ClienteViewModel>();
            CreateMap<Clientes, ClienteEnderecoViewModel>();
            CreateMap<Enderecos, EnderecoViewModel>();
            CreateMap<Enderecos, ClienteEnderecoViewModel>();
        }
    }
}
