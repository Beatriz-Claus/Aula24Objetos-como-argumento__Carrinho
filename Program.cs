using System;

namespace Aula24
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho cart = new Carrinho();
            
            Produto p1 = new Produto(1,  "Iphone 11 Pro Max", 7500.99f);
            Produto p2 = new Produto(2, "Samsung A51", 3900.99f);
            Produto p3 = new Produto(3, "Lg ", 3900.99f);
            Produto p4 = new Produto(4, "Motorola", 3900.99f);

            cart.Adicionar(p1);
            cart.Adicionar(p2);
            cart.Adicionar(p3);
            cart.Adicionar(p4);

            cart.Remover(p3);

            Produto p5 = new Produto(1,  "Iphone 11 Pro Max", 7500.99f);
            cart.Alterar(1, p5);

            cart.Ler();
            cart.MostrarTotal();
        }
    }
}