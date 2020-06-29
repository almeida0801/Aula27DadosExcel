using System;

namespace Aula27DadosExcel
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            produto.Codigo = 1;
            produto.Nome = "Fender";
            produto.Preco = 4500f;

            produto.Cadastrar(produto);
        }
    }
}
