using System;

namespace TemplateMethod
{
    /// <summary>
    /// The AbstractClass participant which contains the template method.
    /// </summary>
    public abstract class Bread
    {
        /// <summary>
        /// The template method defines the skeleton of an algorithm.
        /// </summary>
        public void Make()
        {
            MixIngredients();
            Bake();
            Slice();
            Console.WriteLine();
        }

        /// <summary>
        /// These operations already have implementations.
        /// </summary>
        protected void Message()
        {
            Console.WriteLine("AbstractClass says: start cooking");
        }

        /// <summary>
        /// Mix the ingredients together.
        /// </summary>
        public abstract void MixIngredients();

        /// <summary>
        /// Bake the mixture.
        /// </summary>
        public abstract void Bake();

        /// <summary>
        /// Slice the resulting bread.
        /// </summary>
        /// <remarks>
        /// These are "hooks".
        /// Subclasses may override them, but it's not mandatory since the hooks already have default implementation.
        /// Hooks provide additional extension points in some crucial places of the algorithm.
        /// </remarks>
        public virtual void Slice()
        {
            Console.WriteLine($"Slicing the {GetType().Name} bread!");
        }
    }
}