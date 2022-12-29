using AB.Estoque.Application.ViewModel.Cliente;
using AB.Estoque.Application.ViewModel.Fornecedor;
using AB.Estoque.Application.ViewModel.Produto;
using AB.Estoque.Domain.Models;
using AutoMapper;

namespace AB.Estoque.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Clientes, ClienteViewModel>().ReverseMap();
            CreateMap<Clientes, ClienteEnderecoViewModel>().ReverseMap();
            CreateMap<Enderecos, EnderecoViewModel>().ReverseMap();
            CreateMap<Enderecos, ClienteEnderecoViewModel>().ReverseMap();
            CreateMap<Fornecedores, FornecedorViewModel>().ReverseMap();
            CreateMap<Fornecedores, FornecedorProdutoViewModel>().ReverseMap();
            CreateMap<Produtos, ProdutoViewModel>().ReverseMap();
            CreateMap<Produtos, FornecedorProdutoViewModel>().ReverseMap();
        }
    }
}
