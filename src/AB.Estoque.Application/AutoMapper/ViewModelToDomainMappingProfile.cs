using AB.Estoque.Application.ViewModel.Cliente;
using AB.Estoque.Domain.Models;
using AutoMapper;


namespace AB.Estoque.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<ClienteViewModel, Clientes>();
            CreateMap<ClienteEnderecoViewModel, Clientes>();
            CreateMap<EnderecoViewModel, Enderecos>();
            CreateMap<ClienteEnderecoViewModel, Enderecos>();
        }
    }
}
