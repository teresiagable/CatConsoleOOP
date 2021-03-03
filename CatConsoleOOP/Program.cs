using System;

namespace CatConsoleOOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Car myCar = new Car("Mitsubishi","Space Star",1999);
            myCar.maxSpeed= 155;
            myCar.RegPlate = "ncs491";

            Console.WriteLine(myCar.ToString() +"\n");

            Car ulfsCar = new Car("BMW", "Something", 1981);
            myCar.maxSpeed = 255;
            myCar.RegPlate = "ulf123";


            Console.WriteLine(ulfsCar.CarToString() + "\n");


            Car fredriksCar = new Car("Volvo", "suv", 2020, 200, "abc123");
            
            Console.WriteLine(fredriksCar.CarToString() + "\n");
            Console.WriteLine("Total number of cars: " +Car.NumberOfCars);

        }
        /*static void Main2(string[] args)
        {
            Cat myCat = new Cat("Sphynx", "Blue tabby", 2011);
            myCat.name = "Ossian";
            myCat.RegNr = "C2325Sbt4";

            Console.WriteLine(myCat.ToString() + "\n");

            Cat my2Cat = new Cat("BondKatt", "Svartvit", 1981);
            my2Cat.name = "Mimmi";
            my2Cat.RegNr = "C232bksv4";

            Console.WriteLine(my2Cat.ToString() + "\n");


            Cat my3Cat = new Cat("Angora", "Grey", 1999, "Hobbe", "C345ahgb4");

            Console.WriteLine(my3Cat.ToString() + "\n");

            Console.WriteLine("Total number of cats: " + Cat.NumberOfCats);

        }*/
    }
}
