using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPrimeiroApp
{
    class Program
    {
        private const double v = 954.00;
        private static double salario;

        static void Main(string[] args)
        {
            var valorInformado = Console.ReadLine();


            double valor = Convert.ToDouble(valorInformado);
            double fgts = 8.0 / 100.0;
            double valor_descontado = fgts * valor;

            double valor1 = Convert.ToDouble(valorInformado);
            double inss = 11.0 / 100.0;
            double valor_descontado1 = inss * valor1;


            string empressa;
            empressa = "Toyota";

            salario = Convert.ToDouble(valorInformado);


            Console.WriteLine(valor_descontado + "+" + valor_descontado1);


            Console.WriteLine("João foi contratado para trabalhar na " + empressa + " para fazer os contra-cheque dos funcionarios, ele ira fazer os seguintes descontos:");
            Console.WriteLine("FGTS = 8%");
            Console.WriteLine("INSS = 11%");
            Console.WriteLine("V.T = 6%");
            Console.WriteLine("V.A = 5%");

            Console.WriteLine("O Salario de Pedro é de " + salario + ", este é o valor bruto de seu salario, agora, faremos os descontos");

            Console.WriteLine("Para fazermos o desconto do FGTS, precisamos descontar 8% do seu salario Bruto de " + salario + ", Fazemos isso do seguinte modo: 954 - 8% (FGTS) =  R$" + valor_descontado);
            Console.WriteLine("Para fazermos o desconto do INSS é um pouco diferente, Descontamos 11% do salario bruto, ficaria mais ou menos assim:  R$" + valor_descontado1);
            Console.WriteLine("Valor final fica em: R$" + (valor - valor_descontado - valor_descontado1));








            Console.WriteLine("Para fechar, Tecle Enter!");
            Console.ReadKey();
        }
}
