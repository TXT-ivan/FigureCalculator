using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculator
{
    public abstract class Figure
    {
        public abstract Dictionary<string, object> Calculate();
        public abstract void SetParameters(Dictionary<string, object> parameters);
    }
}
