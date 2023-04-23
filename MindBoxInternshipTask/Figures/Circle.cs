using MindBoxInternshipTask.Abstraction;

namespace MindBoxInternshipTask.Figures
{
    public class Circle : Figure
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius < 0) throw new ArgumentException("Радиус не может быть отрицательным");
            Radius = radius;
        }

        protected override double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
