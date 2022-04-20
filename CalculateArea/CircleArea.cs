namespace CalculateArea
{
    public class CircleArea
    {
        private double _radius;
        private double _area;

        public CircleArea(double radius)
        {

            if (radius<0)
            {
                throw new Exception("Вы ввели отрицальный радиус");
            }
            _radius = radius;
         
        }

        public double СalculationCircleArea()
        {

            _area = Math.PI * Math.Pow(_radius, 2);
            return _area;                        
        }
    }
}