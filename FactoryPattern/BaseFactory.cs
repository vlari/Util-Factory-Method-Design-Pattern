using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class BaseFactory
    {
        /// <summary>
        /// Main product interface. Objects that the factory method will create.
        /// </summary>
        abstract class Product
        {
        }

        /// <summary>
        /// Implements the product.
        /// </summary>
        class ConcreteProduct : Product
        {
        }

        /// <summary>
        /// Contains the implementations for methods to manipulate products.
        /// Declares factory method that returns an object of type product.
        /// </summary>
        class Creator
        {
        }

        /// <summary>
        /// Overrides the factory method to return an instance of a concrete product.
        /// </summary>
        class ConcreteCreator
        {
        }
    }
}
