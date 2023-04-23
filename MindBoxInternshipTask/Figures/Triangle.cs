using MindBoxInternshipTask.Abstraction;

namespace MindBoxInternshipTask.Figures
{
    public class Triangle : Figure
    {
        public List<double> Sides { get; }

        private readonly Lazy<bool> _isRightTriangle;
        public bool IsRightTriangle => _isRightTriangle.Value;

        public Triangle(double edgeA, double edgeB, double edgeC)
        {
            if (edgeA + edgeB <= edgeC || edgeA + edgeC <= edgeB || edgeC + edgeB <= edgeA)
            {
                throw new ArgumentException("Треугольника с такими сторонами не существует");
            }

            if (edgeA <= 0 || edgeB <= 0 || edgeC <= 0)
            {
                throw new ArgumentException("Сторона треугольника не может быть отрицательной");
            }

            Sides = new List<double>(){ edgeA, edgeB, edgeC };

            _isRightTriangle = new Lazy<bool>(GetIsRightTriangle);
        }

        protected override double GetSquare()
        {
            double halfPerimeter = HalfPerimeter();

            return Math.Sqrt(halfPerimeter 
                             * (halfPerimeter - Sides[0]) 
                             * (halfPerimeter - Sides[1]) 
                             * (halfPerimeter - Sides[2])
                             );
        }

        protected double HalfPerimeter()
        {
            return 0.5 * Sides.Sum();
        }

        private bool GetIsRightTriangle()
        {
            Sides.Sort(); //Наибольшая сторона является гипотенузой 

            if (Math.Pow(Sides[2], 2) - (Math.Pow(Sides[0], 2) + Math.Pow(Sides[1], 2)) == 0)
            {
                return true;
            }

            return false;
        }
    }
}
