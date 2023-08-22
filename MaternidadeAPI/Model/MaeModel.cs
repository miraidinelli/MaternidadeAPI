namespace MaternidadeAPI.Model
{
    public class MaeModel
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Sobrenome { get; set; } = string.Empty;
        public string Etnia { get; set; } = string.Empty;
        public DateTime Nascimento { get; set; }
        public string Profissao { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
        public string EstadoCivil { get; set; } = string.Empty;
        public string Fone { get; set; } = string.Empty;
        public string RG { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public string Historico { get; set; } = string.Empty;
        public List<RecemNascidoModel> Filhos { get; set; }

    }
}
