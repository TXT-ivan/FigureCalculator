using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculator
{
    internal interface IFigureCalculator
    {
        abstract Dictionary<string, object> CalculateSquare(Dictionary<string, object> parameters, string type);
    }
}
