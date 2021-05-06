using System;

namespace Desimal_to_Hexadesimal
{
    class program
    {
        public static void Main(string[] args)
        {
            int desimal, hasil;
            int i = 1, j, temp = 0;
            char[] hexadesimal = new char[100];
            char temp1;
            Console.WriteLine("Bilangan Desimal :");
            desimal = int.Parse(Console.ReadLine());
            hasil = desimal;
            while (hasil != 0)
            {
                temp = hasil % 16;
                if (temp < 10)
                    temp = temp + 48;
                else
                    temp = temp + 55;
                temp1 = Convert.ToChar(temp);
                hexadesimal[i++] = temp1;
                hasil = hasil / 16;
            }
            Console.Write("Bilangan Hexadesimal ");
            for (j = i - 1; j > 0; j--)
                Console.Write(hexadesimal[j]);
            Console.Read();

        }
    }
}