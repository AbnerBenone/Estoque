using AB.Estoque.Application.ViewModel.Cliente;
using AB.Estoque.Application.ViewModel.Fornecedor;
using AB.Estoque.Application.ViewModel.Produto;
using AB.Estoque.Domain.Models;
using AutoMapper;


namespace AB.Estoque.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<ClienteViewModel, Clientes>().ReverseMap();
            CreateMap<ClienteEnderecoViewModel, Clientes>().ReverseMap();
            CreateMap<EnderecoViewModel, Enderecos>().ReverseMap();
            CreateMap<ClienteEnderecoViewModel, Enderecos>().ReverseMap();
            CreateMap<FornecedorViewModel, Fornecedores>().ReverseMap();
            CreateMap<FornecedorProdutoViewModel, Fornecedores>().ReverseMap();
            CreateMap<ProdutoViewModel, Produtos>().ReverseMap();
            CreateMap<FornecedorProdutoViewModel, Produtos>().ReverseMap();
        }
    }
}
