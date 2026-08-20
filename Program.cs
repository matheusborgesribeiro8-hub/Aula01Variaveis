using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Aula01variaveis //nome do projeto
{ 
    public class Program
    {
    
        
        static void Main(string[] args)
        {
            CalcularDescontoInss();
        }
         public  static void  CalcularDescontoInss()
        {
            Console.Clear();
    Console.WriteLine("=== Cálculo de Desconto INSS 2026 ===");
    Console.Write("Digite o valor do salário bruto (R$): ");
    
    // Convert puro e direto
    double salario = Convert.ToDouble(Console.ReadLine());
    
    double aliquota = 0;
    double inss = 0;

    if (salario <= 1621.00)
    {
        aliquota = 7.5;
        inss = salario * 0.075;
    }
    else if (salario <= 2902.84)
    {
        aliquota = 9.0;
        inss = salario * 0.09;
    }
    else if (salario <= 4354.27)
    {
        aliquota = 12.0;
        inss = salario * 0.12;
    }
    else if (salario <= 8475.55)
    {
        aliquota = 14.0;
        inss = salario * 0.14;
    }
    else
    {
        aliquota = 14.0;
        inss = 8475.55 * 0.14;
        Console.WriteLine("Aviso: Salário acima do teto do INSS.");
    }

    double salarioLiquido = salario - inss;

    // Exibição usando o formato clássico de chaves {0} para duas casas decimais
    Console.WriteLine("\nAlíquota aplicada: {0}%", aliquota);
    Console.WriteLine("Valor do INSS a pagar: R$ {0:F2}", inss);
    Console.WriteLine("Salário Líquido (com desconto): R$ {0:F2}", salarioLiquido);

    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
    Console.ReadKey();

        }
        
        
        
        
        
        
        
        
            






           // DetalharData(); 

        
    
              public  static void  DetalharData()
            {
                Console.Clear(); 
                Console.WriteLine("Detalhar Data"); 
                Console.WriteLine("Digite uma data dd/MM/yyyy");

                if
                    (DateTime.TryParse(Console.ReadLine(), out DateTime dataDigitada))

                { 
                 string diaSemana = dataDigitada.ToString("dddd");
                 string mesExterno = dataDigitada.ToString("MMMM");

                 Console.WriteLine("\nDia da Semana :" + diaSemana); 
                 Console.WriteLine("Mês: " + mesExterno);

                 if (dataDigitada.DayOfWeek == DayOfWeek.Sunday)
                    {
                        string horaAtual = DateTime.Now.ToString("HH:mm"); 
                        Console.WriteLine("Como hoje é domingo, a hora atual é: " + horaAtual);
                    }
                }

                
                else
                {
                    Console.WriteLine("Data inválida! Use o formato dd/MM/yyyy.");

                }
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                
                }
    
            

        
            // Console.WriteLine("Observe o menu abaixo e digite o número referente a opção desejada: ");
            // Console.WriteLine("1 - Concatenar Palavras");
            // Console.WriteLine("2 - Verificar Dia da semana");
            // Console.WriteLine("3 - Calcular Média");
            // Console.WriteLine("4 - Calcular Tabuada"); 

            // int opcaoEscolhida = int.Parse(Console.ReadLine());

            // switch (opcaoEscolhida)
            // {
            //     case 1:
            //     ConcatenarPalavras();
            //     break;
            //     case 2:
            //     VerificarAulaEtec();
            //     break;
            //     case 3:
            //     CalcularMedia();
            //     break;
            //     case 4:
            //     CalcularTabuada();
            //     break;
                //  case 5:
                //  DetalharData();
                //  break; 
            //     default: 
            //     Console.WriteLine("Opção Inválida");
            //     break;



            // }
            
            


       
       
       
       
       
       
            
            
        //ConcatenarPalavras();
            //CalcularMedia();
             //CalcularTabuada();
             //VerificarAulaEtec(); 
        
        
        
        public static void VerificarAulaEtec()
        {
            Console.WriteLine("Digite a data");
            DateTime data = DateTime.Parse(Console.ReadLine()??"0");

            if(data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Final de semana! Hoje não tem aula! Revisarei exercícios.");

            }
            else
            {
               Console.WriteLine("Dia da semana! Bora pra Etec!");

            }



        }
        
        
        
        
        
                public static void CalcularTabuada()
        {
            Console.WriteLine("Digite a tabuada que deseja calcular");
            int tabuada = int.Parse(Console.ReadLine()??"0");
            int contador = 0; 

            while (contador <= 10)
            {
               string mensagem = string.Format("{0} X {1} = {2}", tabuada, contador, tabuada * contador);
            

            Console.WriteLine(mensagem); 
            contador++; 


            }
        
        
        
        }








        public static void CalcularMedia()
        {
           Console.WriteLine("Digite a primeira nota"); 
           decimal nota1 = decimal.Parse(Console.ReadLine()??"0");

           Console.WriteLine("Digite a segunda nota");
           decimal nota2 = decimal.Parse(Console.ReadLine()??"0");

           decimal media = (nota1 + nota2) / 2;
           Console.WriteLine($"A média é {media}");

           if(media >= 7)
                Console.WriteLine("Aprovado");
           else if(media < 7 && media >= 4)
                 Console.WriteLine("Recuperação");
            else
                Console.WriteLine("Reprovado");
                
                }




        







        public static void ConcatenarPalavras()
        {
            Console.WriteLine("Digite o seu nome");
            string nome = Console.ReadLine()??"0";

            string frase1 = $"Olá {nome}, hoje é {DateTime.Now}";
            Console.WriteLine(frase1);
            Console.WriteLine("====================");

            Console.WriteLine("Quando custa um dólar em reais?"); 
            decimal valorDolarReais = decimal.Parse(Console.ReadLine()??"0");
            string frase2 = string.Format("Hoje é {0:dd/MM/yyyy}, o dólar está custando {1:c2}", DateTime.Now, valorDolarReais); 
            Console.WriteLine(frase2);
            Console.WriteLine("===================");

            string cabecalho = string.Format("{0:dd} de {0:MMMM} de {0:yy} - {0:HH:mm:ss}", DateTime.Now);
            Console.WriteLine(cabecalho);

 

          
         } 
    }
    
}


    

    



    



