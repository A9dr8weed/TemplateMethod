using TemplateMethod.ConcreteClass;

namespace TemplateMethod
{
    public static class Program
    {
        private static void Main()
        {
            Bread sourdough = new Sourdough();
            sourdough.Make();

            Bread twelveGrain = new TwelveGrain();
            twelveGrain.Make();

            Bread wholeWheat = new WholeWheat();
            wholeWheat.Make();
        }
    }
}