namespace MaternidadeAPI.Model
{
    public class RecemNascidoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Genero { get; set; } = string.Empty;
        public string Parto { get; set; } = string.Empty;
        public DateTime Nascimento { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set;}
        public string Condicao { get; set; } = string.Empty;
        public MaeModel Mae { get; set; }
    }
}
