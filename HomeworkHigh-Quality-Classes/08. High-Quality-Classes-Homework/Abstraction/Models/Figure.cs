namespace Abstraction
{
    using Interfaces;

    abstract class Figure : IPerimeterCalculator, ISurfaceCalculator
    {
        public abstract double CalcPerimeter();

        public abstract double CalcSurface();
    }
}
