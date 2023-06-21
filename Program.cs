namespace cSharp_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example AnyName = new Example(2);
            //AnyName.getDoubleNumberOfWheels();
            //Console.WriteLine(Example.someNumber);
            //Example anyValue = new Example(3);
            //anyValue.getDoubleNumberOfWheels();
            //Console.WriteLine(Example.someNumber);

            //AnyName.getDoubleNumberOfWheels();
            //Console.WriteLine(Example.someNumber);

            //OuterClass.nestedClass nested = new OuterClass ();
            //Console.WriteLine();

            // Task 1: Person
            Student std = new Student("Mohammed", 24, 32483, "Cyber");
            std.PrintData();




            //Task 2: Shape
            Rectangle rec = new Rectangle("Yellow",6, 3, 4);
            Console.WriteLine($"The color of rectangle is {rec.color} and the area is {rec.CalArea()}");

            //Task 3: Vehicle
            Car1 car = new Car1("A", 2005, "S", 4);
            car.VehicleData();
        }
    }
}