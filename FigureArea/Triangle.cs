namespace FigureArea
{
    public class Triangle : Figure
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (!IsValidTriangle(sideA, sideB, sideC))
                throw new ArgumentException("Такой треугольник не может существовать");

            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        // Проверяем может ли треугольник существовать с помощью неравенства треугольника
        public bool IsValidTriangle(double sideA, double sideB, double sideC)
        {
            return sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
        }

        // Для вычисления площади треугольника по трем сторонам может быть использована формула Герона
        public override double CalculateArea()
        {
            double semiPerimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
            return Math.Round(area, 3);
        }

        // Для проверки на то, является ли треугольник прямоугольным, воспользуемся теоремой Пифагора
        public bool isRightTriangle ()
        {
            double[] sides = { sideA, sideB, sideC };
            Array.Sort(sides);  // Сортируем стороны по возрастанию

            double a = sides[0];
            double b = sides[1];
            double c = sides[2];

            return c * c == (a * a + b * b);
        }
    }
}
