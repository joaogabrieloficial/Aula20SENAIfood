using System;

namespace Aula20SENAIfood
{
    class Program
    {
        static void Main(string[] args)
        {
         Restaurante churascaria = new Restaurante("BOI BÃO", "av. xambreca");
         System.Console.WriteLine(churascaria.NomeFantasia);
         System.Console.WriteLine(churascaria.Endereço);

         Cliente joao = new Cliente("Gabriel", "AV.dos troxa");
         System.Console.WriteLine(joao.Nome);
         System.Console.WriteLine(joao.EnderecoAtual);

         Pedido buffalo =new Pedido();
         buffalo.Cliente = "Januario";
         buffalo.Itens = "Carne de buffalo";
         buffalo.Restaurante = "Boi Bão";
         buffalo.FormaDePagamento =" cartão de crédito";
         buffalo.PedidoPago = true;
         buffalo.EntregarPedido();

         


         
        }
    }
}
