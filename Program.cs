using System;

namespace POO_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Bem vindo a calculdora portátil C#");
            Console.WriteLine(" ");
            Console.WriteLine("Escolha as opções disponiveis na calculadora");
            Console.WriteLine("---------------------");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("---------------------");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtrair(); break;
                case 3: Multiplicar(); break;
                case 4: Dividir(); break;
                case 5: Sair(); break;

            }

        }
        static void Sair()
        {
            Console.Clear();

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Obrigado por usar nossa aplicação <3");
            Console.WriteLine("-------------------------------------");
            System.Environment.Exit(0); //Sai da aplicação #ÉISTO
        }
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Insira o primeiro valor para somar");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor para somar");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            double resultado = v1 + v2;
            Console.Clear();

            Console.WriteLine($"O resultado da sua soma é {resultado}");

            Console.WriteLine(" ");

            Console.WriteLine("Digite 1 para uma nova soma ou 5 para voltar ao Menu");

            short res = short.Parse(Console.ReadLine());

            if (res == 1)
            {
                Soma();
            }
            else
            {
                Menu();
            }

        }
        static void Subtrair()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor para subtrair");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor para subtrair");
            double v2 = double.Parse(Console.ReadLine());

            double resultado = v1 - v2;

            Console.Clear();
            Console.WriteLine($"O resultado da sua subtração é {resultado}");

            Console.WriteLine("");

            Console.WriteLine("Digite 1 para uma nova subtração ou 5 para voltar ao Menu");

            short res = short.Parse(Console.ReadLine());

            if (res == 1)
            {
                Subtrair();
            }
            else
            {
                Menu();
            }

        }
        static void Multiplicar()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor para multiplicar");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor para multiplicar");
            double valor2 = double.Parse(Console.ReadLine());

            double resultado = valor1 * valor2;

            Console.Clear();

            Console.WriteLine("O resultado da multiplicação é " + resultado);

            Console.WriteLine("");

            Console.WriteLine("Digite 1 para uma nova multiplicação ou 5 para voltar ao Menu");

            short res = short.Parse(Console.ReadLine());

            if (res == 1)
            {
                Multiplicar();
            }
            else
            {
                Menu();
            }

        }
        static void Dividir()
        {
            Console.Clear();

            Console.WriteLine("Digite o número que vai ser dividido");
            double valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor que vai dividir o primeiro");
            double valor2 = double.Parse(Console.ReadLine());

            double resultado = valor1 / valor2;

            Console.Clear();

            Console.WriteLine($"O resultado da divisão é {resultado}");

            Console.WriteLine("");

            Console.WriteLine("Digite 1 para uma nova divisão ou 5 para voltar ao Menu");
            short res = short.Parse(Console.ReadLine());

            if (res == 1)
            {
                Dividir();
            }
            else  {
                Menu();
            }
               
           
        }
    }
}
