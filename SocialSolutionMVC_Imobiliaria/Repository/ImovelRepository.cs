using SocialSolutionMVC_Imobiliaria.Data;
using SocialSolutionMVC_Imobiliaria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialSolutionMVC_Imobiliaria.Repository
{
    public class ImovelRepository : IImovelRepository
    {
        private readonly BancoContext _bancoContext;
        public ImovelRepository(BancoContext bancocontext)
        {
            _bancoContext = bancocontext;
        }

        public ImovelModel ListarPorId(int id)
        {
            return _bancoContext.Imoveis.FirstOrDefault(x => x.Id == id);
        }

        public List<ImovelModel> BuscarTodos()
        {
            return _bancoContext.Imoveis.ToList();
        }

        public ImovelModel Adicionar(ImovelModel imovel)
        {
            _bancoContext.Imoveis.Add(imovel);                 //gravar no banco de dados
            _bancoContext.SaveChanges();
            return imovel;
        }

        public ImovelModel Atualizar(ImovelModel imovel)
        {
            ImovelModel imovelDB = ListarPorId(imovel.Id);

            if (imovelDB == null) throw new System.Exception("Houve um erro na atualização do imovel");

            imovelDB.TipoNegocio = imovel.TipoNegocio;
            imovelDB.VlrImovel = imovel.VlrImovel;
            imovelDB.Desc = imovel.Desc;
            imovelDB.StatusImovel = imovel.StatusImovel;

            _bancoContext.Imoveis.Update(imovelDB);
            _bancoContext.SaveChanges();

            return imovelDB;
        }

        public bool Apagar(int id)
        {
            ImovelModel imovelDB = ListarPorId(id);
            if (imovelDB == null) throw new System.Exception("Houve um erro na atualização do imovel");

            _bancoContext.Imoveis.Remove(imovelDB);
            _bancoContext.SaveChanges();

            return true;
        }



    }
}
