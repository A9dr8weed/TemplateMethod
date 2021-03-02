using System;

namespace TemplateMethod.ConcreteClass
{
    /// <summary>
    /// Concrete classes have to implement all abstract operations of the base class.
    /// They can also override some operations with a default implementation.
    /// </summary>
    public class WholeWheat : Bread
    {
        public override void MixIngredients()
        {
            Console.WriteLine("Gathering Ingredients for Whole Wheat Bread.");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking the Whole Wheat Bread. (15 minutes)");
        }
    }
}