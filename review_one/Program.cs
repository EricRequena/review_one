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

        //*Afegeix una funcionalitat al programa anterior que permeti emmagatzemar ciutats i els seus respectius codis postals. El programa ha de demanar el nom i el codi fins que l’usuari introdueixi un valor per finalitzar la introducció de dades i mostrar un llistat amb format dels valors introduïts. */
        string[] ciutats = new string[100];
        int[] codis = new int[100];
        int i = 0;
        string ciutat;
        int codi;
        do
        {
            Console.WriteLine("Introdueix el nom de la ciutat");
            ciutat = Console.ReadLine();
            if (ciutat != "")
            {
                ciutats[i] = ciutat;
                Console.WriteLine("Introdueix el codi postal de la ciutat");
                codi = Convert.ToInt32(Console.ReadLine());
                codis[i] = codi;
                i++;
            }
        } while (ciutat != "");
        Console.WriteLine("Llistat de ciutats i codis postals");
        for (int j = 0; j < i; j++)
        {
            Console.WriteLine(ciutats[j] + " - " + codis[j]);
        }



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

