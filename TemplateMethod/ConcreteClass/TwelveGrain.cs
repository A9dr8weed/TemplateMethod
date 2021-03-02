using System;

namespace TemplateMethod.ConcreteClass
{
    /// <summary>
    /// Concrete classes have to implement all abstract operations of the base class.
    /// They can also override some operations with a default implementation.
    /// </summary>
    public class TwelveGrain : Bread
    {
        public override void MixIngredients()
        {
            Console.WriteLine("Gathering Ingredients for 12-Grain Bread.");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking the 12-Grain Bread. (25 minutes)");
        }
    }
}