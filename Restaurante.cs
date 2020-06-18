namespace Aula20SENAIfood
{
    public class Restaurante
    {
        public string NomeFantasia { get; set; }
        public string Endereço { get; set; }

          public Restaurante(string _nome, string _endereco){
            this.NomeFantasia = _nome;
            this.Endereço = _endereco;

        }
        
            
    }
}