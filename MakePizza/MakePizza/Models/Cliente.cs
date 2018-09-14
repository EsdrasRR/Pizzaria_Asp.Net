using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace MakePizza.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        #region Propriedades

        [Key]
        public int IdCliente { get; set; }

        public List<Pedido> PedidoCliente  { get; set; }

        [Display(Name = "Nome Cliente")]
        [Required(ErrorMessage = "Nome Obrigatório ")]
        public string NomeCliente { get; set; }

        [Display(Name = "CEP Cliente")]
        [MaxLength (8, ErrorMessage = "Digite somente os números de seu CEP." )]
        public string CepCliente { get; set; }

        [Display(Name = "CPF Cliente")]
        [MaxLength (11, ErrorMessage = "Digite somente os números de seu CPF." )]
        public string CpfCliente { get; set; }

        [Display(Name = "Email Cliente")]
        [Required(ErrorMessage = "Email Obrigatório ")]
        public string EmailCliente { get; set; }

        [Display(Name = "Senha Cliente")]
        [Required(ErrorMessage = "Senha Obrigatório ")]
        public string SenhaCliente { get; set; }

        [Display(Name = "Permissão ADM Cliente")]
        [Required(ErrorMessage = "Permissão Obrigatório ")]
        public bool AdminCliente { get; set; }

        #endregion
    }
}