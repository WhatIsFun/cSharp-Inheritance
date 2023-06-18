namespace cSharp_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Example AnyName = new Example(2);
            AnyName.getDoubleNumberOfWheels();
            Console.WriteLine(Example.someNumber);
            Example anyValue = new Example(3);
            anyValue.getDoubleNumberOfWheels();
            Console.WriteLine(Example.someNumber);

            AnyName.getDoubleNumberOfWheels();
            Console.WriteLine(Example.someNumber);

            //OuterClass.nestedClass nested = new OuterClass ();
            //Console.WriteLine();
            Console.WriteLine("Hello, World!");
        }
    }
}