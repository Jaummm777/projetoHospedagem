namespace ProjetoHospedagem.Models
{
    public class Pessoa
    {
        public Pessoa() {}

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }
    }
}
