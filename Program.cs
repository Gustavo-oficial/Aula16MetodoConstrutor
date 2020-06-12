using System;

namespace Aula16Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto sapato = new Produto();

            Produto carteira = new Produto(20);
            System.Console.WriteLine(carteira.Estoque);


            System.Console.WriteLine();

            Produto corta = new Produto(529841, "Nike", "Azul", 2000);
            System.Console.WriteLine($"O codigo do produto é {corta.Codigo}, marca {corta.Nome}, de cor {corta.Descricao}, somente {corta.Estoque} no estoque, CORRA esse modelo é de colecionador, portanto, tem estoque limitado");
    
        }
    }
}