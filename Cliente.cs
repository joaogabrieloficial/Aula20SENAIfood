namespace Aula20SENAIfood
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string EnderecoAtual { get; set; }

        public  Cliente(string _nome, string _endereco){
            this.Nome =_nome;
            this.EnderecoAtual = _endereco;

        

        }
    }
}