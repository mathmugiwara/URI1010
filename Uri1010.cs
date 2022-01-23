using System;
using System.Globalization;

namespace URI1010
{
    class Program
    {
        /*Neste problema, deve-se ler o código de uma peça 1, o número de peças 1,
         * o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor 
         * unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.

         Entrada
         O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores,
        respectivamente dois inteiros e um valor com 2 casas decimais.

        Saída
        A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, lembrando
        de deixar um espaço após os dois pontos e um espaço após o "R$". O valor deverá ser apresentado
        com 2 casas após o ponto.*/
        static void Main(string[] args)
        {

            string[] vet = Console.ReadLine().Split(' ');
            int numero = int.Parse(vet[0]);
            int quantidade = int.Parse(vet[1]);
            double valor = double.Parse(vet[2], CultureInfo.InvariantCulture);
            string[] ve = Console.ReadLine().Split(' ');
            int number = int.Parse(ve[0]);
            int quantity = int.Parse(ve[1]);
            double price = double.Parse(ve[2], CultureInfo.InvariantCulture);
            double resultado = (quantidade * valor) + (quantity * price);
            Console.WriteLine("VALOR A PAGAR: R$ " + resultado.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
