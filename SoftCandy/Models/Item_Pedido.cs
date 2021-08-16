﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SoftCandy.Models
{
    public class Item_Pedido
    {
        [Required(ErrorMessage = "{0} obrigatório")]
        [Display(Name = "Preço Pago")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public decimal Preco_Pago { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [Display(Name = "Código Produto")]
        [ForeignKey("Produto")]
        public int Cod_Produto { get; set; }
        public  virtual Produto Produto { get; set; }

        [Key()]
        [Required(ErrorMessage = "{0} obrigatório")]
        [Display(Name = "Número Pedido")]
        [ForeignKey("Cliente")]
        public int Num_Pedido { get; set; }
        public virtual  Pedido Pedido { get; set; }
    }
}
