using FactoryMethod.Abstract;
using FactoryMethod.Concrete;

namespace FactoryMethod;


class Program
{
    static void Main()
    {

        Creator? creator = null;
        Product? product = null;
        while (true)
        {
            Console.WriteLine(@"
                                1: ProductA
                                2: ProductB
                                Any: Exit");

            Console.Write("\n\tEnter choice: ");


            creator = Console.ReadLine() switch
            {
                "1" => new ConcreteCreatorA(),
                "2" => new ConcreteCreatorB(),
                _ => null
            };

            if (creator == null)
                break;
            product = creator?.CreateProduct();
            product?.DoStuff();
        }
    }
}
