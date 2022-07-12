using FactoryMethod.Abstract;
using FactoryMethod.Concrete;

namespace FactoryMethod;


class Program
{
    static void Main()
    {

        Creator? logistics = null;
        Product? transport = null;

        while (true)
        {
            Console.WriteLine(@"
                                1: ProductA
                                2: ProductB
                                Any: Exit");

            Console.Write("\n\tEnter choice: ");


            logistics = Console.ReadLine() switch
            {
                "1" => new ConcreteCreatorA(),
                "2" => new ConcreteCreatorB(),
                _ => null
            };

            if (logistics == null)
                break;
            transport = logistics?.CreateProduct();
            transport?.DoStuff();
        }
    }
}
