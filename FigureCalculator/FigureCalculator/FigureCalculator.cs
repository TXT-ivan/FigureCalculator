namespace FigureCalculator
{
    public class FigureCalculator : IFigureCalculator
    {
        public Dictionary<string, object> CalculateSquare(Dictionary<string, object> parameters, string type)
        {
            var result = new Dictionary<string, object>();

            Figure figure;
            var figureType = Type.GetType($"FigureCalculator.{type}", false);

            if (figureType == null)
            {
                result.Add("Ошибка", "Не найден указанный тип фигуры.");
                return result;
            }

            var obj = Activator.CreateInstance(figureType);

            if (obj != null)
            {
                figure = (Figure)obj;

                try
                {
                    figure.SetParameters(parameters);
                }
                catch 
                {
                    result.Add("Ошибка", "Ошибка входных параметров.");
                    return result;
                }

                try
                {
                    result = figure.Calculate();
                }
                catch 
                {
                    result.Add("Ошибка", "Ошибка при подсчётах. Обратитесь в поддержку по номеру +7-923-526-27-37");
                    return result;
                }
            }

            return result;
        }
    }
}