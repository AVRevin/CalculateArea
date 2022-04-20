using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class TriangleArea
    {
        private double _side_1;
        private double _side_2;
        private double _side_3;
        private double _half_perimeter;
        private double _area;

        public TriangleArea(double side_1, double side_2, double side_3)
        {

            if (side_1 < 0 || side_2 < 0 || side_3 < 0)
            {
                throw new Exception("Вы ввели отрицальную сторону");
            }
            _side_1 = side_1;
            _side_2 = side_2;
            _side_3 = side_3;
        }


        public bool CheckRightTriangle()
        {
            // Sort sides
            double[] triangle = new double[3];
            triangle[0] = _side_1;
            triangle[1] = _side_2;
            triangle[2] = _side_3;
            Array.Sort(triangle);

            // Calculate RightTriangle
            if (Math.Pow(triangle[0], 2) + Math.Pow(triangle[1], 2) == Math.Pow(triangle[2], 2))
            {
                return true;
            }

            return false;
        }


        public double СalculationTriangleArea()
        {
            _half_perimeter = (_side_1 + _side_2 + _side_3)/2;
            _area = Math.Sqrt(_half_perimeter * (_half_perimeter - _side_1) * (_half_perimeter - _side_2) * (_half_perimeter - _side_3));
            return _area;
        }
    }
}
