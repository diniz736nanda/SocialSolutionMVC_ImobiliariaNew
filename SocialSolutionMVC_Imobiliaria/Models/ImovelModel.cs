using SocialSolutionMVC_Imobiliaria.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SocialSolutionMVC_Imobiliaria.Models
{
    public class ImovelModel
    {
        public int Id { get; set; }

//        [Required(ErrorMessage = "Digite o nome completo")]
        public TipNegocio TipoNegocio { get; set; }

//        [Required(ErrorMessage = "Digite o nome completo")]
        public double VlrImovel { get; set; }

//       [Required(ErrorMessage = "Digite o nome completo")]
        public string Desc { get; set; }

//      [Required(ErrorMessage = "Digite o nome completo")]
        public StatusImovel StatusImovel { get; set; }

//      [Required(ErrorMessage = "Digite o nome completo")]
        public ClienteModel Cliente { get; set; }
    }
}

