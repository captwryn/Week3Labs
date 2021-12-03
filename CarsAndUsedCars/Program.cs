using System;
using System.Collections.Generic;

namespace CarsAndUsedCars
{
    class Car
    {
        
        public string make;
        public string model;
        public int year;
        public decimal price;
        public double mileage = 0;

        

        public Car (string makea, string modela, int yeara, decimal pricea)
            {
            make = makea;
            model = modela;
            year = yeara;
            price = pricea;
            }
        public override string ToString()
        {
            return $"\n  Make: {make}\n  Model: {model}\n  Year: {year}\n  Mileage: {mileage}\n  Price: ${price}\n";
        }
        public static List<Car> Cars = new List<Car>();
    }
    class UsedCar : Car 
    {

        public UsedCar(string make, string model, int year, double miles, decimal price) : base(make, model, year, price)
        {
        mileage = miles;
        }
        public override string ToString()
        {
            return $"\n  Make: {make}\n  Model: {model}\n  Year: {year}\n  Mileage: {mileage}\n  Price: ${price}\n";
        }
        public static List<Car> UsedCars = new List<Car>();
    }
    class Program
    {
       
        static void Main(string[] args)
        {


            Car.Cars.Add(new Car("Honda", "Civic", 2021, 21250m));
            Car.Cars.Add(new Car("Honda", "Accord", 2021, 24970m));
            Car.Cars.Add(new Car("Honda", "CR-V", 2021, 25350m));
            Car.Cars.Add(new Car("Ford", "F-150", 2021, 29290m));
            Car.Cars.Add(new Car("Ford", "Mustang", 2021, 27205m));
            Car.Cars.Add(new Car("Ford", "Explorer", 2021, 32925m));
            Car.Cars.Add(new Car("Ferrari", "812 Superfast", 2021, 404494m));
            Car.Cars.Add(new Car("Ferrari", "SF90 Spider", 2021, 558000m));
            Car.Cars.Add(new Car("Ferrari", "F8 Tributo", 2021, 276550m));
            Car.Cars.Add(new Car("Tesla", "Model Y", 2021, 39990m));
            Car.Cars.Add(new Car("Tesla", "Model X", 2021, 79990m));
            Car.Cars.Add(new Car("Tesla", "Model 3", 2021, 44990m));

            Car.Cars.Add(new UsedCar("Tesla", "Model 3", 2019, 10377, 56990m));
            Car.Cars.Add(new UsedCar("Ford", "Mustang", 2016, 15964, 65990m));
            Car.Cars.Add(new UsedCar("Ford", "Escape", 2018, 65074, 19590m));
            Car.Cars.Add(new UsedCar("Nissan", "Versa", 2018, 46205, 14990m));
            Car.Cars.Add(new UsedCar("Volkswagen", "Jetta", 2014, 67762, 15990m));
            Car.Cars.Add(new UsedCar("Buick", "LaCrosse", 2010, 98824, 15590m));
            Car.Cars.Add(new UsedCar("Cadillac", "CTS", 2011, 15990, 99031m));
            Car.Cars.Add(new UsedCar("Hyundai", "Sonata", 2010, 72448, 14990m));

            List<string> makelist = new List<string>() { "Buick", "Cadillac", "Ferrari", "Ford", "Honda", "Hyundai", "Nissan", "Tesla", "Volkswagen" };
            List<double> yearlist = new List<double>() {2021,2019,2018,2016,2014,2011,2010 };
            List<int> LHList = new List<int>() { 1, 2 };

            bool keepgoing = true;
            //foreach (Car thing in Car.Cars)
            //{
            //    Console.WriteLine(thing);
            //}
            Console.WriteLine("Hello, welcome to our dealership!");

            do
            {
                Console.WriteLine("Please select an option for finding your new car today: (0) Purchase a car (1) Browse by Make (2) Browse by Year (3) Browse by Price");
                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Please select a make: (1) Buick (2) Cadillac (3) Ferrari (4) Ford (5) Honda (6) Hyundai (7) Nissan (8) Tesla (9) Volkswagen");
                    option = int.Parse(Console.ReadLine());
                    foreach (Car thing in Car.Cars)
                    {
                        if (thing.make == makelist[option - 1])
                        {
                            Console.WriteLine(thing);
                        }
                    }

                }
                if (option == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Please choose a year:");
                    for (int i = 0; i < yearlist.Count; i++)
                    {
                        Console.WriteLine($"({i + 1}) {yearlist[i]}");
                    }
                    option = int.Parse(Console.ReadLine());
                    foreach (Car thing in Car.Cars)
                    {
                        if (thing.year == yearlist[option - 1])
                        {
                            Console.WriteLine(thing);
                        }
                    }

                }
                if (option == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Please select: (1) Price Low to High (2) Price High to Low");
                    option = int.Parse(Console.ReadLine());
                    if (option == 1)
                    {
                        Console.Clear();
                        Car.Cars = Car.Cars.OrderBy(o => o.price).ToList();
                        foreach (Car thing in Car.Cars)
                        {
                            Console.WriteLine(thing);
                        }
                    }
                    if (option == 2)
                    {
                        Console.Clear();
                        Car.Cars = Car.Cars.OrderByDescending(o => o.price).ToList();
                        foreach (Car thing in Car.Cars)
                        {
                            Console.WriteLine(thing);
                        }
                    }
                }

                //if (option == 4)
                //{
                //    //Console.WriteLine("For Used Cars select: (1) Mileage Low to High (2) Mileage High to Low");
                //    //option = int.Parse(Console.ReadLine());
                //    //if (option == 1)
                //    //{
                //    //    Car.Cars = Car.Cars.OrderBy(o => o.mileage).ToList();
                //    //    foreach (UsedCar thing in UsedCar.Cars)
                //    //    {
                //    //        Console.WriteLine(thing);
                //    //    }
                //    //}
                //    //if (option == 2)
                //    //{
                //    //    Car.Cars = Car.Cars.OrderByDescending(o => o.mileage).ToList();
                //    //    foreach (UsedCar thing in UsedCar.Cars)
                //    //    {
                //    //        Console.WriteLine(thing);
                //    //    }
                //    //}
                //}
                if (option == 0)
                {
                    Console.WriteLine("Which car would you like to buy?:");
                    bool emode = true;
                    do
                    {
                        Car.Cars = Car.Cars.OrderBy(o => o.price).ToList();
                        int i = 0;
                        foreach (Car thing in Car.Cars)
                        {
                            Console.WriteLine($"  ---{i}---");
                            Console.WriteLine(thing);
                            i++;
                        }
                        option = int.Parse(Console.ReadLine());
                        Console.WriteLine("  --- Confirm buy: (1) Yes ---");
                        int ays = -1;
                        Console.WriteLine(Car.Cars[option]);
                        ays = int.Parse(Console.ReadLine());
                        if (ays == 1)
                        {
                            Car.Cars.RemoveAt(option);

                        }
                        
                        Console.WriteLine("Would you like to buy another car? (1) Yes (2) No");
                        option = int.Parse(Console.ReadLine());
                        if (option == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Which car would you like to buy?:");
                        }
                        if (option == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Leaving purchase Mode");
                            emode = false;
                        }
                    }
                    while (emode);
                }

                option = -1;
                Console.WriteLine("Would you like to browse are cars more? (1) Yes (anything else) Leave Store.");
                option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.Clear();
                }
                if (option != 1)
                {
                    Console.WriteLine("Thank you for shopping with us today.");
                    keepgoing = false;
                }
            }
            while (keepgoing);

        }
    }
}