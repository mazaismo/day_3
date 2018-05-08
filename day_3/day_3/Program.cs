using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int skaitlis = Funkcija1();
            Funkcija2();
            Funkcija2();
            Funkcija2();
            Console.WriteLine(skaitlis);
            Console.ReadLine();
        }

        static int Funkcija1() //sakaitisim a un b //
        {
            int a = 5;
            int b = 10;


            int c = a + b;

            return c;
        }

        static void Funkcija2()
        {
            Console.WriteLine("apaļš ābols bumbierim cep čību");
            Console.WriteLine("divmetrīgā eglē ērglis filmē gliemežu ģimeni");

        }
    }
}