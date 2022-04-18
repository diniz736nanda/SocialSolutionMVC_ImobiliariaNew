using SocialSolutionMVC_Imobiliaria.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SocialSolutionMVC_Imobiliaria.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome completo")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o e-mail")]
        [EmailAddress(ErrorMessage = "O e-mail informado não é o valido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite o CPF")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Informe o status do imóvel")]
        public StatusCliente StatusCliente { get; set; }
        public List<ImovelModel> Imoveis { get; set; } = new List<ImovelModel>();

    }
}
