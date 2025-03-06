// See https://aka.ms/new-console-template for more information
using System;

namespace Aula01Variaveis
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ConcatenarPalavra();
           //VerificarAulaEtec();
           //CalcularMedia();
            DetalharData();
            CalcularDescontoINSS();

        }

        public static void CalcularMedia()
        {
            Console.WriteLine("Digite a primeira nota");
            decimal nota1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            decimal nota2 = decimal.Parse(Console.ReadLine());

            decimal media = (nota1 + nota2) / 2;
            Console.WriteLine($"A média é {media}");

            if(media >= 7)
            Console.WriteLine("Aprovado!");
            else if(media < 7 && media >= 4)
            Console.WriteLine("Recuperação!");
            else
            Console.WriteLine("Reprovado!"); 
        }

        public static void VerificarAulaEtec()
        {
            Console.WriteLine("Digite a data");
            DateTime data = DateTime.Parse (Console.ReadLine());

            if(data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Final de semana! Hoje não tem aula! Revisarei os exercicios.");
            }
            else
            {
                Console.WriteLine("Dia da semana! Bora pra Etec!");
            }
        }

        public static void ConcatenarPalavra()
        {
            Console.WriteLine("Digite seu nome:" ); 
            String nome = Console.ReadLine();

            String frase1 = $"Olá {nome}, hoje é {DateTime.Now}";
            Console.WriteLine(frase1);
            Console.WriteLine(" ");

            Console.WriteLine("Quanto custa um dolar em reais?");
            decimal valorDolarReais = decimal.Parse(Console.ReadLine());
            string frase2 = string.Format("Hoje é {0:dddd}, o dolár está custando {1:c2}", DateTime.Now, valorDolarReais);
            Console.WriteLine(frase2);

            Console.WriteLine(" ");
            string cabecalho = string.Format("{0:dddd}, {0:dd} de {0:MMMM} de {0:yyyy} - {0:HH:mm:ss}", DateTime.Now);
            Console.WriteLine(cabecalho.ToUpper());
        }

        public static void DetalharData(){
            
            Console.WriteLine("Insira a data: ");
              DateTime data = DateTime.Parse (Console.ReadLine());
             Console.WriteLine("{0:dddd}, {0:MMMM} de {0:yyyy}.",data);
            if(data.DayOfWeek == DayOfWeek.Sunday){
                Console.WriteLine("A hora atual é : {0:HH:mm}",DateTime.Now);
            }
        }

        public static void CalcularDescontoINSS()
        {
            double inf=0;
            double salaryDescontado=0;

            Console.WriteLine("");

            Console.WriteLine("------------ Valor de Contribuicao INSS ------------");
            Console.WriteLine("");
            Console.WriteLine("insira seu Salário : ");
            double salary = Convert.ToDouble(Console.ReadLine());
            
            if(salary>=0 && salary<=1212)
            {
                 inf = (salary * 0.075) ;
                
            }
            else if(salary >= 1212.01 && salary <= 2427.35)
            {
                 inf= (salary * 0.09) ;
            }
            if(salary >=2427.36 && salary <= 3641.03)
            {
                inf= (salary * 0.12);
            }
            if(salary >=3641.04 && salary <= 7087.22 )
            {
                inf= (salary * 0.14);
            }

            salaryDescontado = salary - inf;
            
          Console.WriteLine("Valor a ser pago pelo INSS : " + inf);
          Console.WriteLine("Salario descontado : " + salaryDescontado);
        }












    }
}