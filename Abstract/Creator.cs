namespace FactoryMethod.Abstract;

abstract class Creator
{
    public void SomeOperation()
        => Console.WriteLine("SomeOperation");

    public abstract Product CreateProduct();
}
