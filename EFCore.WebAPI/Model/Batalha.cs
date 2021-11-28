using System;

namespace EFCore.WebAPI.Model
{
    public class Batalha
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataIncio { get; set; }
        public DateTime DataFim { get; set; }

    }
}