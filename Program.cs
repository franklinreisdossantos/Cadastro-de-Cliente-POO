using Atividade2.modelo;
using System;
using System.Collections.Generic;
using System.Text;



namespace Atividade2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Leitura dos dados da cor

            Console.WriteLine("Digite o nome da cor");
            string nomecor = Console.ReadLine();

            Console.WriteLine("Digite o valor do R");
            int r = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do G");
            int g = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B");
            int b = int.Parse(Console.ReadLine());
            
            //Instaciando uma cor
            Cor cor1 = new Cor();
            cor1.Nome = nomecor;
            cor1.R = r;
            cor1.G= g;
            cor1.B= b;
            Console.WriteLine("Informe qual veiculo ,Digite 1 para carro 2 para lancha e 3 para aviao");
            int tipo = int.Parse( Console.ReadLine());
            if (tipo == 1)
            {   
                Console.WriteLine("Você escolheu carro");
                //********************
                //Criando objeto Carro
                //********************
                Console.WriteLine("Digite o modelo");
                string modelo = Console.ReadLine();


                Console.WriteLine("Digite o Fabricante");
                string fabricante = (Console.ReadLine());

                Console.WriteLine("Digite o ano");
                int ano = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a Placa");
                string placa = Console.ReadLine();

                Console.WriteLine("Tem ar condicionado false/true");
                bool arcon = bool.Parse(Console.ReadLine());

                Console.WriteLine("Tem step false/true");
                bool step = bool.Parse(Console.ReadLine());

                //Instaciando a classe carro
                Carro carro1 = new Carro();
                carro1.Modelo = modelo;
                carro1.Ano = ano;
                carro1.Placa = placa;
                carro1.Fabricante = fabricante;
                carro1.Arcon = arcon;
                carro1.Cor = cor1;
                carro1.Step = step;

                Console.Clear();
                Console.WriteLine("***************************");
                Console.WriteLine("*Caracteristicas do Veiculo*");
                Console.WriteLine("***************************");
                Console.WriteLine($"Modelo:{carro1.Modelo}\nAno:{carro1.Ano}\n Placa :{carro1.Placa}\n Fabricante:{carro1.Fabricante}\n Cor:{ carro1.Fabricante = carro1.Cor.Nome}");
                Console.ReadKey();
            }




            else if (tipo == 2)
            {
                Console.WriteLine("Você escolheu lancha");
                //***********************
                //Criando o objeto Lancha
                //***********************
                Console.WriteLine("Qual modelo da lancha");
                string modelo1 = Console.ReadLine();

                Console.WriteLine("Qual o preço da lancha");
                int preco1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Qual o peso da lancha");
                int peso = int.Parse(Console.ReadLine());

                Console.WriteLine("Qual o ano da Lancha");
                int ano1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Quantidade de motores");
                int motor = int.Parse(Console.ReadLine());

                Lancha lancha1 = new Lancha();
                lancha1.Modelo = modelo1;
                lancha1.Preco = preco1;
                lancha1.Peso = peso;
                lancha1.Ano = ano1;
                lancha1.Cor = cor1;
                lancha1.QuantidadedeMotores = motor;
                Console.Clear();
                Console.WriteLine("*Caracteristicas do Veiculo*");
                Console.WriteLine("***************************");
                Console.WriteLine($"Modelo:{lancha1.Modelo}\nPreço:{lancha1.Preco}\n Peso :{lancha1.Ano}\n Cor:{ lancha1.Cor.Nome}");
                Console.ReadKey();
            }

            else if (tipo == 3)
            {
                Console.WriteLine("Você escolheu avião");
                //**********************
                //Criando o objeto aviao
                //**********************
                Console.WriteLine("Qual modelo ");
                string modelo3 = Console.ReadLine();

                Console.WriteLine("Qual o ano");
                int ano3 = int.Parse(Console.ReadLine());

                Console.WriteLine("Qualo o prefixo");
                string prefixo = (Console.ReadLine());

                Console.WriteLine("Qual o valor");
                double valor3 = double.Parse(Console.ReadLine());

                Console.WriteLine("Horas voo");
                int voo1 = int.Parse(Console.ReadLine());

                Aviao aviao1 = new Aviao();
                aviao1.Modelo = modelo3;
                aviao1.Ano = ano3;
                aviao1.Prefixo = prefixo;
                aviao1.Valor = valor3;
                aviao1.Horasvoo = voo1;
                aviao1.Cor = cor1;

                Console.Clear();
                Console.WriteLine("*Caracteristicas do Veiculo*");
                Console.WriteLine("***************************");
                Console.WriteLine($"Modelo:{aviao1.Modelo}\nPreço:{aviao1.Ano}\n Peso :{aviao1.Ano}\n Cor:{ aviao1.Cor.Nome}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Você não escolheu a opção correta");
                Console.ReadKey();
            }


            

































        }
    }
}
