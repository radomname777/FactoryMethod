using FactoryMethod.Abstract;

namespace FactoryMethod.Concrete;

class ConcreteCreatorB : Creator
{
    public override Product CreateProduct() => new ProductB();
}
