using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculator
{
    internal class Triangle : Figure
    {
        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;

        public override Dictionary<string, object> Calculate()
        {
            var result = new Dictionary<string, object>();

            var p = (_firstSide + _secondSide + _thirdSide) / 2;
            var square = Math.Sqrt(p * (p - _firstSide) * (p - _secondSide) * (p - _thirdSide));
            var rectangular = Math.Pow(_firstSide, 2) + Math.Pow(_secondSide, 2) == Math.Pow(_thirdSide, 2) ? true : false;

            result.Add("Square", square);
            result.Add("Rectangular", rectangular);

            return result;
        }

        public override void SetParameters(Dictionary<string, object> parameters)
        {
            parameters.TryGetValue("FirstSide", out object firstSide);
            parameters.TryGetValue("SecondSide", out object secondSide);
            parameters.TryGetValue("ThirdSide", out object thirdSide);

            _firstSide = Convert.ToDouble(firstSide);
            _secondSide = Convert.ToDouble(secondSide);
            _thirdSide = Convert.ToDouble(thirdSide);
        }
    }
}
