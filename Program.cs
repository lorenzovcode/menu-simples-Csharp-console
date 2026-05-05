using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    internal class Program
    {
        // FUNÇÃO 1 IMC
        static string imc()
        {
            double altura=0, peso=0, imc;
            int z = 0;
            string classificacao;

            while (z < 1)
            {
                Console.WriteLine("Vamos determinar o IMC.");
                Console.Write("Digite seu peso em kg: ");
                peso = Convert.ToDouble(Console.ReadLine());
                if (peso <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Você digitou um valor inválido. Por favor digite novamente.");
                    continue;
                }
                z++;
            }
            while (z < 2)
            {
                Console.Write("Digite sua altura em m: ");
                altura = Convert.ToDouble(Console.ReadLine());
                if (altura <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Você digitou um valor inválido. Por favor digite novamente.");
                    continue;
                }
                z++;
            }
                    
            imc = peso / (altura * altura);
            Console.WriteLine($"Seu IMC é de {imc:F2} kg/m²");

            if (imc <= 18.5)
            {
                classificacao = "Você está abaixo do peso.";
            }
            else if (imc <= 24.9)  
            {
                classificacao = "Você está com peso normal";
            }
            else if (imc <= 29.9)
            {
                classificacao = "Você está com sobrepeso";
            }
            else if (imc <= 34.9)
            {
                classificacao = "Você tem Obesidade grau I";
            }
            else if (imc <= 39.9)
            {
                classificacao = "Você tem Obesidade grau II";
            }
            else
            {
                classificacao = "Você tem Obesidade grau III";
            }

                return classificacao;
        }
        
        // FUNÇÃO 2 NÚMERO MAIOR E MENOR
        static string maiormenor()
        {
            double maiornumero = 0, menornumero = 0;
            double x, y, z;
            Console.WriteLine("Entre três números, vamos ver qual é o maior e qual o menor.");
            Console.Write("Digite o primeiro número: ");
            x = Convert.ToDouble(Console.ReadLine());
            maiornumero = x;
            menornumero = x;

            Console.Write("Digite o segundo número: ");
            y = Convert.ToDouble(Console.ReadLine());
            if (y > maiornumero) { maiornumero = y; }
            if (y < menornumero) { menornumero = y; }

            Console.Write("Digite o terceiro número: ");
            z = Convert.ToDouble(Console.ReadLine());
            if (z > maiornumero) { maiornumero = z; }
            if (z < menornumero) { menornumero = z; }

            return $"O maior número é {maiornumero} e o menor número é {menornumero}";

        }

        // FUNCÃO NÚMERO PAR OU ÍMPAR
        static string paridade()
        {
            int z=0;
            double numero=0;
            string paridade="a";
            while (z < 1)
            {
                Console.WriteLine("Vamos determinar se um número é par ou ímpar.");
                Console.Write("Digite um número inteiro: ");
                numero = Convert.ToDouble(Console.ReadLine());
                if (numero != Convert.ToInt32(numero))
                {
                    Console.Clear();
                    Console.WriteLine("O número não é inteiro. Digite novamente.");
                    continue;
                }
                z++;               
            }

            if (numero % 2 == 0)
            {
                paridade = "par";
            }
            else
            {
                paridade = "ímpar";
            }

            return paridade;
        }

        // FUNÇÃO EQUAÇÃO DE 2 GRAU
        static string eq2grau()
        {
            double a, b, c, delta, x, x1, x2;
            int z = 0;
            string resposta="a";

            while (z < 1)
            {             
                Console.WriteLine("Vamos calcular as raízes de uma equação de 2º grau.");
                Console.Write("Digite o valor de a: ");
                a = Convert.ToDouble(Console.ReadLine());

                if (a == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Se a for zero, a equação não é de segundo grau. Digite outro valor.");
                    continue ;
                }

                Console.Write("Digite o valor de b: ");
                b = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o valor de c: ");
                c = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Temos a seguinte equação do 2º grau: {a}x² + ({b}x) + ({c})");

                delta = Math.Pow(b, 2) - (4 * a * c);
                Console.WriteLine($"DELTA = {delta} ");

                if (delta < 0)
                {
                    resposta = "Delta é negativo e a equação não possui valores reais.";
                }

                if (delta == 0)
                {
                    x = -b / (2 * a);
                    resposta = $"Delta é zero, portanto a equação possui apenas uma raiz, que é x = {x:F2} .";
                }

                if (delta > 0)
                {
                    x1 = (-b + (Math.Sqrt(delta))) / (2 * a);
                    x2 = (-b - (Math.Sqrt(delta))) / (2 * a);

                    resposta = $"Delta é positivo, e a equação possui duas raízes reais, que são x1 = {x1:F2} e x2 = {x2:F2} ";
                }
                z++;
            }
            return resposta;
        }

        // FUNCÃO FAHRENHEIT PARA CELSIUS
        static string fahrenheit_para_celsius() 
        {
            string resposta = "a";
            int z = 0;
            double f = 0, c = 0;

            while (z < 1)
            {
                Console.WriteLine("Vamos converter a temperatura de graus Fahrenheit para graus Celsius.");
                Console.Write("Digite o valor da temperatura em graus Fahrenheit: ");
                f = Convert.ToDouble(Console.ReadLine());

                if (f < -459.67)
                {
                    Console.Clear();
                    Console.WriteLine("Este valor é menor do que o zero absoluto em graus Fahrenheit. Digite outro valor.");
                    continue;
                }

                c = (f - 32) / 1.8;

                resposta = $"O valor {f} ºF é igual à {c:F2} ºC.";
                z++;
            }
           
            return resposta;
        }

        // FUNÇÃO GRAUS CELCIUS PARA FAHRENHEIT
        static string celsius_para_fahrenheit()
        {
            string resposta="a";
            int z= 0;
            double f= 0, c = 0;

            while (z < 1)
            {
                Console.WriteLine("Vamos converter a temperatura de graus Celsius para graus Fahrenheit.");
                Console.Write("Digite a temperatura em graus Celsius: ");
                c = Convert.ToDouble(Console.ReadLine());

                if (c < -273.15)
                {
                    Console.Clear();
                    Console.WriteLine("Este valor é menor do que o zero absoluto em graus Celsius. Digite outro valor.");
                    continue;
                }

                f = (c * 1.8) + 32;

                resposta = $"O valor {c} ºC é igual à {f:F2} ºF";
                z++;
            }

            return resposta;
        }
        
        static void Main(string[] args)
        {
            int escolha, z=0;
            string novamente="x";
            string prefixo = "Deseja utilizar o programa novamente? s / n: [";
            string sufixo = "]";

            while (z < 1)
            {
                Console.Clear();

                Console.WriteLine("=-=-=-=-= MENU DE OPÇÕES DO PROGRAMA =-=-=-=-=");
                Console.WriteLine("1 - Cálculo do IMC");
                Console.WriteLine("2 - Mostrar número Maior e Menor");
                Console.WriteLine("3 - Par ou Ímpar");
                Console.WriteLine("4 - Equação do 2º grau");
                Console.WriteLine("5 - Fahrenheit para Celsius");
                Console.WriteLine("6 - Celsius para Fahrenheit");
                Console.WriteLine("10 - SAIR DO PROGRAMA");
                Console.WriteLine("=-=-=-=-==-=-=-=-==-=-=-=-==-=-=-=-==-=-=-=-=");
                Console.Write("Escolha uma opção: ");
                escolha = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                if (escolha == 1)
                {
                    Console.WriteLine("=-=-= Você escolheu 1 - Cálculo do IMC =-=-=");
                    Console.WriteLine(imc());

                    Console.Write(prefixo + " " + sufixo);
                    Console.SetCursorPosition(prefixo.Length, Console.CursorTop);
                    novamente = Console.ReadLine();
                    if (novamente == "s")
                    {
                        continue;
                    }
                    else
                    {
                        z++;
                    }
                }
                else if (escolha == 2)
                {
                    Console.WriteLine("=-=-= Você escolheu 2 - Mostrar número Maior e Menor =-=-=");
                    Console.WriteLine(maiormenor());

                    Console.Write(prefixo + " " + sufixo);
                    Console.SetCursorPosition(prefixo.Length, Console.CursorTop);
                    novamente = Console.ReadLine();
                    if (novamente == "s")
                    {
                        continue;
                    }
                    else
                    {
                        z++;
                    }
                }
                else if (escolha == 3)
                {
                    Console.WriteLine("=-=-= Você escolheu 3 - Par ou Ímpar =-=-=");
                    Console.WriteLine($"O número digitado é {paridade()}");

                    Console.Write(prefixo + " " + sufixo);
                    Console.SetCursorPosition(prefixo.Length, Console.CursorTop);
                    novamente = Console.ReadLine();
                    if (novamente == "s")
                    {
                        continue;
                    }
                    else
                    {
                        z++;
                    }

                }
                else if (escolha == 4)
                {
                    Console.WriteLine("=-=-= Você escolheu 4 - Equação do 2º grau =-=-=");
                    Console.WriteLine(eq2grau());

                    Console.Write(prefixo + " " + sufixo);
                    Console.SetCursorPosition(prefixo.Length, Console.CursorTop);
                    novamente = Console.ReadLine();
                    if (novamente == "s")
                    {
                        continue;
                    }
                    else
                    {
                        z++;
                    }
                }
                else if (escolha == 5) 
                {
                    Console.WriteLine("=-=-= Você escolheu 5 - Fahrenheit para Celsius =-=-=");
                    Console.WriteLine(fahrenheit_para_celsius());

                    Console.Write(prefixo + " " + sufixo);
                    Console.SetCursorPosition(prefixo.Length, Console.CursorTop);
                    novamente = Console.ReadLine();
                    if (novamente == "s")
                    {
                        continue;
                    }
                    else
                    {
                        z++;
                    }
                }
                else if (escolha == 6)
                {
                    Console.WriteLine("=-=-= Você escolheu 6 - Celsius para Fahrenheit =-=-=");
                    Console.WriteLine(celsius_para_fahrenheit());

                    Console.Write(prefixo + " " + sufixo);
                    Console.SetCursorPosition(prefixo.Length, Console.CursorTop);
                    novamente = Console.ReadLine();
                    if (novamente == "s")
                    {
                        continue;
                    }
                    else
                    {
                        z++;
                    }
                }
                else if (escolha == 10)
                {
                    z++;
                }
                else
                {
                    Console.WriteLine("Você digitou um valor inválido. Pressione qualquer tecla e digite novamente.");
                    Console.ReadLine();
                    continue;
                }
            }
        }
    }
}
