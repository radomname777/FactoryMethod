using FactoryMethod.Abstract;

namespace FactoryMethod.Concrete;

class ConcreteCreatorA : Creator
{
    public override Product CreateProduct() => new ProductA();
}
