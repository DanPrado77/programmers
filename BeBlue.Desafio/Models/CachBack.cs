﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BeBlue.Desafio.Models
{
    public class CashBack
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        [Required]
        public int IdGenero { get; set; }
        [Required]
        public int DiaSemana { get; set; }
        [Required]
        public decimal Porcentagem { get; set; }

    }
}
