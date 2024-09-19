using System;

class Program
{
    static void Main(string[] args)
    {
        //Introduir les notes
        int nota1 = Numero(1);
        int nota2 = Numero(2);
        int nota3 = Numero(3);

        //Mostrar el promig de les notes
        Console.WriteLine("El promig de les notes es: " + Suma(nota1, nota2, nota3));

        //Mostrar si l'alumne ha aprovat o suspès
        Answer(Suma(nota1, nota2, nota3));
    }
    public static void Answer(float answer)
    {
        if (answer >= 6)
        {
            Console.WriteLine("Aprovat");
        }
        else if (answer < 6)
        {
            Console.WriteLine("Suspès");
        }
    }

    public static int Numero(int number)
    {


        Console.WriteLine($"Introdueix la {Order(number)} qualificació");
        int nota = Convert.ToInt32(Console.ReadLine());
        return nota;

    }
    public static string Order(int number)
    {
        if (number == 1)
        {
            return "primera";
        }
        else if (number == 2)
        {
            return "segona";
        }
        else
        {
            return "tercera";
        }
    }
    public static float Suma(float a, float b, float c)
    {
        return (a + b + c) / 3;
    }
}

