using FactoryMethod.Abstract;

namespace FactoryMethod.Concrete;

class ProductA : Product
{
    public void DoStuff()
    {
        Console.ForegroundColor = ConsoleColor.Blue ;
        Console.WriteLine("ProductA");
    }
}
