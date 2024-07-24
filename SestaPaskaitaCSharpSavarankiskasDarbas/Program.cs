using SestaPaskaitaCSharpSavarankiskasDarbas.Models;

namespace MyProgram
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            /*Task 1*/
            Console.WriteLine("TASK 1");
            Automobilis auto = new Automobilis("Audi", 2000);
            Console.WriteLine(auto.Marke + " " + auto.Metai);

            /*Task 2*/
            Console.WriteLine("TASK 2");
            int age = int.Parse(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("Nepilnametis");
            }
            else if (age >= 18 && age < 75)
            {
                Console.WriteLine("Pilnametis");
            }
            else
            {
                Console.WriteLine("Senioras");
            }

            /*Task 3*/
            Console.WriteLine("TASK 3");
            for (int i = 1; i <= 10; i++)
            {
                { Console.WriteLine(i); }
            }

            /*Task 4*/
            Console.WriteLine("TASK 4");
            int num = 0;
            while (num < 5)
            {
                num++;
                Console.WriteLine(num);
            }

            /*Task 5*/
            Console.WriteLine("TASK 5");
            Studentas stud1 = new Studentas("Rokis Balboa" , 10);
            Studentas stud2 = new Studentas("Ricky Gervais", 6);
            Studentas stud3 = new Studentas("Petka", 2);

            if(stud1.ArIslaike())
            {
                Console.WriteLine(stud1.Vardas + " išlaikė egzaminą");
            }

            if (stud2.ArIslaike())
            {
                Console.WriteLine(stud2.Vardas + " išlaikė egzaminą");
            }

            if (stud3.ArIslaike())
            {
                Console.WriteLine(stud3.Vardas + " išlaikė egzaminą");
            }

        }
    }
}