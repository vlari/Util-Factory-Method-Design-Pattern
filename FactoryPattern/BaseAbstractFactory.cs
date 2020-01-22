using System;

public class BaseAbstractFactory {

    
}

// abstract objects
abstract class AbstractProduct1 {}

abstract class AbstractProduct2 {}

// AbstractFactory
abstract class AbstractFactory {
    public abstract AbstractProduct1 CreateAbstractProduct1();
    public abstract AbstractProduct2 CreateAbstractProduct1();
}

class ConcreteProduct1 : AbstractProduct1 {}

class ConcreteProduct2 : AbstractProduct2 {}

class ConcreateFactory : AbstractFactory {
    public override AbstractProduct1 CreateAbstractProduct1() 
    {
        return ConcreteProduct1();
    }

    public override AbstractProduct2 CreateAbstractProduct2() 
    {
        return ConcreteProduct2();
    }

    
}