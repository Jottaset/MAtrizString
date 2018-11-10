using System;

namespace matrizString
{
    class Program
    {
        static void Main(string[] args)
        {

            string[,] m = new string[2, 2];

            string texto = "";

            for (int i = 0; i < 2;i++){
                for (int j = 0; j < 2; j++){

                    if(j == 0) Console.WriteLine("Informe o Nome: ");
                    if (j ==1)Console.WriteLine("Informe o Sobrenome: ");

                    m[i, j] = Console.ReadLine();
                    texto += m[i, j] + " ";
                }

                texto += "\n";
            }

            Console.WriteLine(texto);
        }
    }
}
