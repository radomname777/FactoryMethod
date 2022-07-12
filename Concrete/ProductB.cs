using FactoryMethod.Abstract;

namespace FactoryMethod.Concrete;

class ProductB : Product
{
    public void DoStuff()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ProductB");
    }
}

