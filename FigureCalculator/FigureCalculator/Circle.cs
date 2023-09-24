using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculator
{
    public class Circle : Figure
    {
        private double _radius;

        public override Dictionary<string, object> Calculate()
        {
            var result = new Dictionary<string, object>();

            var square = Math.PI * Math.Pow(_radius, 2);
            result.Add("Square", square);

            return result;
        }

        public override void SetParameters(Dictionary<string, object> parameters)
        {
            parameters.TryGetValue("Radius", out object radius);
            _radius = Convert.ToDouble(radius);
        }
    }
}
