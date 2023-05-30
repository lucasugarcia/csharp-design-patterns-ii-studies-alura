using DesignPatterns2.Cap7;

namespace DesignPatterns2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FilaDeTrabalho fila = new FilaDeTrabalho();
            Pedido pedido1 = new Pedido("João", 100.0);
            Pedido pedido2 = new Pedido("Maria", 200.0);

            fila.Adiciona(new PagaPedido(pedido1));
            fila.Adiciona(new PagaPedido(pedido2));

            fila.Adiciona(new FinalizaPedido(pedido1));

            fila.Processa();
        }
    }
}