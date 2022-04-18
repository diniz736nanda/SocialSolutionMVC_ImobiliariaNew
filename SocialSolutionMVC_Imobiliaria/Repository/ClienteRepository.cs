using SocialSolutionMVC_Imobiliaria.Data;
using SocialSolutionMVC_Imobiliaria.Models;
using System.Collections.Generic;
using System.Linq;

namespace SocialSolutionMVC_Imobiliaria.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly BancoContext _bancoContext;
        public ClienteRepository(BancoContext bancocontext)
        {
            _bancoContext = bancocontext;
        }
        public ClienteModel ListarPorId(int id)
        {
            return _bancoContext.Clientes.FirstOrDefault(x => x.Id == id);
        }

        public List<ClienteModel> BuscarTodos()
        {
            return _bancoContext.Clientes.ToList();
        }

        public ClienteModel Adicionar(ClienteModel cliente)
        {
            _bancoContext.Clientes.Add(cliente);                 //gravar no banco de dados
            _bancoContext.SaveChanges();
            return cliente;   
        }


        public ClienteModel Atualizar(ClienteModel cliente)
        {
            ClienteModel clienteDB = ListarPorId(cliente.Id);

            if (clienteDB == null) throw new System.Exception("Houve um erro na atualização do cliente");

            clienteDB.Nome = cliente.Nome;
            clienteDB.Email = cliente.Email;
            clienteDB.Cpf = cliente.Cpf;
            clienteDB.StatusCliente = cliente.StatusCliente;

            _bancoContext.Clientes.Update(clienteDB);
            _bancoContext.SaveChanges();

            return clienteDB;
        }


        public bool Apagar(int id)
        {
            ClienteModel clienteDB = ListarPorId(id);
            if (clienteDB == null) throw new System.Exception("Houve um erro na atualização do cliente");

            _bancoContext.Clientes.Remove(clienteDB);
            _bancoContext.SaveChanges();

            return true;



        }
    }
}
