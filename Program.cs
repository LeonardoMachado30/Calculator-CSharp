using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula
{
    class Program
    {
        static double num1 = 0;
        static double num2 = 0;
        static double result = 0;
        static string operador = " ";
        static void descricao()
        {
            Console.WriteLine("\t\t\t _________________________________________________");
            Console.WriteLine("\t\t\t|--------------Olá, seja bem vindo!---------------|");
            Console.WriteLine("\t\t\t|-------------------Calculadora-------------------|");
            Console.WriteLine("\t\t\t|---Insira um dado e logo após pressione Enter.---|");
            Console.WriteLine("\t\t\t|_________________________________________________|\n");
            Console.WriteLine("\t\t\t|Não insisra letras, vai bugar tudo usuario burro |\n");
            Console.Write("\t\t\t---------------------------------------------\n");
            Console.Write("\t\t\t----------------| " + num1 +"   " + operador + "   "+ num2 + " |----------------\n");
            Console.Write("\t\t\t---------------------------------------------\n");
        }
        /* verifica se o numero e negativo ou nao*/
        static bool retornarNumerosPositivos(double num)
        {
            if(num >= 0)
            {
                return true;
            }
            return false;
        }

        static string retornoValor()
        {
            var key = "";
            string controle1 = "<-";
            string controle2 = " ";
            string controleKeyPress = " ";

            do
            {
                Console.Clear();

                descricao();

                Console.Write("\n\n\nEscolha as opções usando as setas, e clique enter");
                Console.Write("\nDeseja fazer outro calculo?");
                Console.Write("\n[1] - Sim " + controle1);
                Console.Write("\n[2] - Não " + controle2);

                key = Console.ReadKey().Key.ToString();

                if (key == "UpArrow")
                {
                    controle1 = "<-";
                    controle2 = " ";
                    controleKeyPress = key;
                }
                if (key == "DownArrow")
                {
                    controle1 = " ";
                    controle2 = "<-";
                    controleKeyPress = key;
                }

                if(controleKeyPress == "DownArrow" && key == "Enter")
                {
                    Environment.Exit(0);
                }

                Console.Clear();

            } while (key != "Enter");
                
            return key;
        }

        static void Main(string[] args)
        {
            var resultKey = "";
            do
            {
                
                descricao();

                Console.Write("\n\t\t\tNumero 1 -> ");
                num1 = Convert.ToDouble(Console.ReadLine());

                var retornoNumero = retornarNumerosPositivos(num1);

                if(retornoNumero == false)
                {
                    Console.WriteLine("Numeros negativos não são aceitos.");
                    resultKey = Console.ReadKey().ToString();
                }

                Console.Clear();
                descricao();

                Console.Write("\n\t\t\tNumero 2 -> ");
                num2 = Convert.ToDouble(Console.ReadLine());

                retornoNumero = retornarNumerosPositivos(num2);

                if (retornoNumero == false)
                {
                    Console.WriteLine("Numeros negativos não são aceitos.");
                    resultKey = "Enter";
                }

                Console.Clear();
                descricao();

                Console.Write("\n[+] - soma");
                Console.Write("\n[-] - subtração");
                Console.Write("\n[*] - multiplicação");
                Console.Write("\n[/] - divisão");
                Console.Write("\n-> ");

                operador = Console.ReadLine();

                Console.Clear();

                descricao();

                switch (operador)
                {
                    case "+":
                        result = num1 + num2;

                        Console.Write("Resultado: " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.Write("Resultado: " + result);

                        break;
                    case "*":
                        result = num1 * num2;
                        Console.Write("Resultado: " + result);

                        break;
                    case "/":
                        result = num1 / num2;
                        Console.Write("Resultado: " + result);

                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("operador nao encontrado, tente um operador da lista!");
                        break;
                }

                resultKey = retornoValor();

            } while (resultKey == "Enter");

            Console.ReadLine();
        }
    }
}