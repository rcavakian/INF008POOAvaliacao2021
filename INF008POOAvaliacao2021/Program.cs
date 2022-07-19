using System;

namespace INF008POOAvaliacao2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //ii. a representação estática da classe criada
            RGB red = new RGB(255, 0, 0);
            RGB vermelho = new RGB(37, 150, 190);
            
            Console.WriteLine("Luminosidade: " + red.ExibirLuminosidade());

            RGB vermelhoCinza = vermelho.ConverterEmCinza(vermelho);

            //vermelho.AlterarBlue(255);
            // vermelho.ExibirAtributos();
            //bool iguais = red.CompararRGB(red, vermelho);

            //Console.WriteLine(iguais);
            //Console.WriteLine("Atributos apos converter em cinza: ");
            //vermelhoCinza.ExibirAtributos();
            //vermelho.ExibirLuminosidade();
            //vermelhoCinza.ExibirLuminosidade();
            //Console.Write("Valor em Hexa: " + red.ExibirHexa());
            Console.WriteLine("Atributos antes do clareamento: ");
            vermelho.ExibirAtributos();
            Console.WriteLine("Atributos apos o clareamento: ");
            vermelho.ClarearCor(0.1);
            vermelho.ExibirAtributos();



        }
    }
}
