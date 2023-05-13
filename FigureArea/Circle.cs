namespace FigureArea
{
    public class Circle : Figure
    {
        private double radius;

        public Circle(double radius)
        {
            if (!IsValidCircle(radius))
                throw new ArgumentException("Такой круг не может существовать");

            this.radius = radius;
        }

        // Проверяем может ли круг существовать 
        public bool IsValidCircle(double radius)
        {
            return radius > 0;
        }

        public override double CalculateArea()
        {
            double area = Math.PI * radius * radius;
            return Math.Round(area, 3);
        }
    }
}
