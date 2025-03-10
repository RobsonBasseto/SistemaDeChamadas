﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FormularioCadastro.Models
{
    [Table("chamada", Schema = "public")]
    public class DbChamada
    {
        [Key]
        public int idchamada { get; set; }
        public string nome { get; set;}
        public string email { get; set;}
        public DateTime datanascimento { get; set; }
        public char sexo { get; set; }
        public string rua { get; set; }
        public int numero { get; set; }
        public string cep { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public int grauurgencia { get; set; }
        public string mensagem { get; set; }
    }
}
