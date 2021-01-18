﻿using Size.Core.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Size.Core.Models
{
    public class Cliente : IEntity, ICliente
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Documento { get; set; }
        public Conta Conta { get; set; }
    }
}
