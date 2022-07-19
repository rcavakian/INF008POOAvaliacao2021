using System;
using System.Collections.Generic;
using System.Text;

namespace INF008POOAvaliacao2021
{
    //i. uma classe que represente uma cor RGB
    /// <summary>
    /// Class para representar uma cor RGB 
    /// </summary>
    public class RGB
    {
        /* 
         * viii.um construtor que receba três valores como parâmetros e crie uma considerando 
         * estes valores como os valores de R, G e B, respectivamente
         */

        //Construtor com inicialização de todos os parametros

        /// <summary>
        /// Inicializando uma nova instância informando os parametros de cada cor
        /// </summary>
        /// <param name="red"></param>
        /// <param name="green"></param>
        /// <param name="blue"></param>
        public RGB(int red, int green, int blue)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
            Luminosidade = (int)Math.Round(red * 0.3 + green * 0.59 + blue * 0.11);
        }

        // Construtor para criar cor Preta 

        /// <summary>
        /// Inicializando a Cor Preta (Red=0, Green=0, Blue=0)
        /// </summary>
        public RGB()
        {
            Red = 0;
            Blue = 0;
            Green = 0;
        }

        //vi. um construtor de cópia, que crie uma cor idêntica(mesmo valor de R, G e B)

        /// <summary>
        /// Construtor cria uma copia de outro objeto da mesma classe
        /// </summary>
        /// <param name="copiaRGB"></param>
        public RGB(RGB copiaRGB)
        {
            Red = copiaRGB.Red;
            Green = copiaRGB.Green;
            Blue = copiaRGB.Blue;
        }

        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public int Luminosidade { get; set; }

        // os métodos que leem e alteram os valores das componentes RGB da cor

        /// <summary>
        /// Método que exibe os atributos atuais da cor
        /// </summary>
        public void ExibirAtributos()
        {
            Console.WriteLine("Atributos: (" + Red.ToString() + ", " + Green.ToString() + ", " + Blue.ToString() + ")");
        }

        /// <summary>
        /// Método que altera todas as cores
        /// </summary>
        /// <param name="red"></param>
        /// <param name="green"></param>
        /// <param name="blue"></param>
        public void AlterarRGB(int red, int green, int blue)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;

            AlterarRed(Red);
            AlterarGreen(Green);
            AlterarBlue(Blue);
            Console.WriteLine("Atributos alterados para: (" + Red.ToString() + ", " + Green.ToString() + ", " + Blue.ToString() + ")");
        }

        /// <summary>
        /// Método que altera apenas o atributo Red(vermelho)
        /// </summary>
        /// <param name="red"></param>
        public void AlterarRed(int red)
        {
            this.Red = red;
        }

        /// <summary>
        /// Método que altera apenas o atributo Green(verde)
        /// </summary>
        /// <param name="green"></param>
        public void AlterarGreen(int green)
        {
            this.Green = green;
        }

        /// <summary>
        /// Método que altera apenas o atributo Blue(azul)
        /// </summary>
        /// <param name="blue"></param>
        public void AlterarBlue(int blue)
        {
            this.Blue = blue;
        }

        /// <summary>
        /// Método retorna o valor (inteiro) da luminosidade da cor (Red * 0.3 + Grenn * 0.59 + Blue * 0.11) 
        /// </summary>
        /// <returns></returns>

        public int ExibirLuminosidade()
        {
            
            int luminosidade = (int)(Math.Round((Red * 0.3) + (Green * 0.59) + (Blue * 0.11), MidpointRounding.AwayFromZero));
           // String hexa = "#" + Red.ToString("X") + Green.ToString("X") + Blue.ToString("X");
           // Console.WriteLine("Cor em Hexa: " + hexa);
            
            return luminosidade;
        }

        // Falta acertar o retorno
        /* 
         * ix. um método que verifique se duas cores são iguais. As cores são consideradas iguais se seus valores de 
         * R, G e B são idênticos entre si(o R de uma cor igual o R da outra e assim por diante)
        */
        /// <summary>
        /// Comparar duas cores(class RGB) e informa se todos os atributos(Red, Green, Blue) são iguais
        /// </summary>
        /// <param name="primeiroRGB"></param>
        /// <param name="segundoRGB"></param>
        /// <returns></returns>
        public bool CompararRGB(RGB primeiroRGB, RGB segundoRGB)
        {
            if (primeiroRGB.Red.Equals(segundoRGB.Red))
            {
                if (primeiroRGB.Green.Equals(segundoRGB.Green))
                {
                    if (primeiroRGB.Blue.Equals(segundoRGB.Blue))
                    {
                        return true;
                    }
                }
            }
            else 
            {
                return false;
            }
            return true;

        }

        /*
         * Metodo comparar o mesmo parametro de dois objetos diferentes
         * switch (cor)
            {
                case "Red":

                    igual = (primeiroRGB.Red == segundoRGB.Red) ? true : false;
                    break;

                case "Green":
                    igual = (primeiroRGB.Green == segundoRGB.Green) ? true : false;
                    break;

                case "Blue":
                    igual = (primeiroRGB.Blue == segundoRGB.Blue) ? true : false;
                    break;

                default:
                    Console.WriteLine(
                        "Cor inválida, utlize apenas os formatos: " +
                        "Red(vermelho), Green(verde) ou Blue(azul)." +
                        " Apenas a primeira letra maiúscula");
                    break;
            }
         */


        /// <summary>
        /// Retornar a partir de uma cor, o equivalente dessa cor na escala cinza
        /// </summary>
        /// <param name="cor"></param>
        /// <returns></returns>
        public RGB ConverterEmCinza(RGB cor)
        {
            RGB corEscalaCinza = new RGB();
            corEscalaCinza.Red = cor.Luminosidade;
            corEscalaCinza.Green = cor.Luminosidade;
            corEscalaCinza.Blue = cor.Luminosidade;

            return corEscalaCinza;
        }

        /*
         xii. um método que gere uma representação String da cor como hexadecimal. A representação é composta
           pelo caracter # seguida de dois dígitos representando o valor de R, G e B em hexadecimal. Por exemplo,
           para a cor RGB, onde R=37, G=150, B=190, o método deve retornar: #2596BE
        */
        /// <summary>
        /// Exibir a cor no formato Hexa #HHHHHH 
        /// </summary>
        /// <returns></returns>
        public string ExibirHexa()
        {
            string hexa = "#" + Red.ToString("X2") + Green.ToString("X2") + Blue.ToString("X2"); 
            return hexa;
        }

        /* xiii.um método clarear que receba um valor e modifique a tonalidade da cor em questão a 
         * tornando mais clara. Para isso, o método deve modificar os valores RGB, para um novo valor 
         * p percentual maior, onde p deve ser indicado como parâmetro.Por exemplo, para a cor #2596BE, 
         * se o parâmetro de clarear for 0.1 (10%), a cor deve se tornar #3BA1C5.
         * */
        /// <summary>
        /// Clarear(1 > p > 0) a cor, onde o "p" representa o percentual em forma decimal  
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public void ClarearCor(double p)
        {
            this.Red = (int)Math.Round(this.Red * (1 + p));
            this.Green = (int)Math.Round(this.Green * (1 + p));
            this.Blue = (int)Math.Round(this.Blue * (1 + p));
        }

        /* 
         * xiv. um método escurecer que receba um valor e modifique a tonalidade da cor 
         * em questão a tornando mais escura.Para isso, o método deve modificar os valores 
         * RGB, para um novo valor p percentual menor, onde p deve ser indicado como parâmetro.
         * Por exemplo, para a cor #2596BE, se o parâmetro de escurecer for 0.1 (10%), a cor 
         * deve se tornar #2187AB.
         */

        /// <summary>
        /// Clarear(1 > p > 0) a cor, onde o "p" representa o percentual em forma decimal
        /// </summary>
        /// <param name="p"></param>
        public void EscurecerCor(double p)
        {
            this.Red = (int)Math.Round(this.Red * (1 - p));
            this.Green = (int)Math.Round(this.Green * (1 - p));
            this.Blue = (int)Math.Round(this.Blue * (1 - p));
        }

    }
}
