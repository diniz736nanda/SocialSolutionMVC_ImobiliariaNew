using SocialSolutionMVC_Imobiliaria.Models;
using System.Collections.Generic;

namespace SocialSolutionMVC_Imobiliaria.Repository
{
    public interface IImovelRepository
    {
        ImovelModel ListarPorId(int id);
        List<ImovelModel> BuscarTodos();
        ImovelModel Adicionar(ImovelModel imovel);
        ImovelModel Atualizar(ImovelModel imovel);
        bool Apagar(int id);
    }
}
