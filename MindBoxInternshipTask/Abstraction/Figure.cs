namespace MindBoxInternshipTask.Abstraction
{
    public abstract class Figure
    {
        public Lazy<double> _square;

        public double Square => _square.Value;

        public Figure()
        {
            _square = new Lazy<double>(GetSquare);
        }

        protected abstract double GetSquare();
    }
}
