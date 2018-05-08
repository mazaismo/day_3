using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int d = Funkcija4(10, 20);
            Funkcija2();
            Funkcija2();
            Funkcija2();
            Funkcija3(5,6);
            


            Console.WriteLine(d);
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

        static void Funkcija3(int skaitlis1, int skaitlis2)
        {
            int c = skaitlis1 + skaitlis2;
            Console.WriteLine(c);

        }

        static int Funkcija4(int skaitlis1, int skaitlis2)
        {
            int d = skaitlis1 + skaitlis2;

            return d;
            

        }
    }
}