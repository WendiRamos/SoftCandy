﻿using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SoftCandy.Models
{
    public class Lote
    {
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [Display(Name = "Quantidade Estoque")]
        public int QuantidadeEstoque { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [Display(Name = "Data de Fabricação")]
        [DataType(DataType.DateTime)]
        public DateTime DataFabricacao { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [Display(Name = "Data de Validade")]
        [DataType(DataType.DateTime)]
        public DateTime DataValidade { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Preco { get; set; }

        [ForeignKey("Produto")]
        [Display(Name = "Produto")]
        public int IdProduto { get; set; }
        public virtual Produto Produto { get; set; }

        public Lote()
        {
        }
    }
}
