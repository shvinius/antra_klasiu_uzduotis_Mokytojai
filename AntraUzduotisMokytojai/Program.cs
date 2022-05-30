using System;

namespace AntraUzduotisMokytojai
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Mokytojai teacher1;

            teacher1 = NuskaitytiMokytoja();

            Console.WriteLine("----------------------------");

            IsvestiMokytojus(teacher1);
        }
        static Mokytojai NuskaitytiMokytoja()
        {
            Mokytojai teacher = new Mokytojai();

            Console.WriteLine("Įveskite mokytojo vardą: ");
            string vardas = Console.ReadLine();
            teacher.Vardas = vardas;
            

           
            Console.WriteLine("Įveskite mokytojo pavardę: ");
            string pavarde = Console.ReadLine();
            teacher.Pavarde = pavarde;
           

            Console.WriteLine("Įveskite mokytojo auklėtinių klasę: ");
            string klase = Console.ReadLine();
            teacher.Klase = klase;
            

            Console.WriteLine("Įveskite mokytojo pareigas: ");
            string pareigos = Console.ReadLine();
            teacher.Pareigos = pareigos;

            Console.WriteLine("Įveskite mokytojo stažą: ");
            int stazas = Convert.ToInt32(Console.ReadLine());
            teacher.Stazas = stazas;

            Console.WriteLine("Įveskite mokytojo išsilavinimas: ");
            string issilavinimas = Console.ReadLine();
            teacher.Issilavinimas = issilavinimas;


            return teacher;
        }
        static void IsvestiMokytojus(Mokytojai teacher)
        {
            Console.WriteLine("Vardas: " + teacher.Vardas);
            Console.WriteLine("Pavardė: " + teacher.Pavarde);
            Console.WriteLine("Mokytojo auklėtinių klasė: " + teacher.Klase);
            Console.WriteLine("Pareigos: " + teacher.Pareigos);
            Console.WriteLine("Stažas: " + teacher.Stazas + "m.");
            Console.WriteLine("Išsilavinimas: " + teacher.Issilavinimas);
        }
    }
}