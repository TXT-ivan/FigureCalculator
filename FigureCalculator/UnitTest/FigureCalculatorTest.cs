using FigureCalculator;

namespace UnitTest
{
    [TestClass]
    public class FigureCalculatorTest
    {
        [TestMethod]
        public void CircleTest()
        {
            var param = new Dictionary<string, object>();
            param.Add("Radius", 5);
            var figureCalculator = new FigureCalculator.FigureCalculator();
            var result = figureCalculator.CalculateSquare(param, "Circle");

            Assert.IsTrue(result.ContainsKey("Square"));
        }

        [TestMethod]
        public void TriangleTest()
        {
            var param = new Dictionary<string, object>();
            param.Add("SecondSide", 4);
            param.Add("ThirdSide", 5);
            param.Add("FirstSide", 3);

            var figureCalculator = new FigureCalculator.FigureCalculator();
            var result = figureCalculator.CalculateSquare(param, "Triangle");

            Assert.IsTrue(result.ContainsKey("Square"));
            Assert.IsTrue(result.ContainsKey("Rectangular"));
        }
    }
}