
namespace ControllingProgramFlow
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            //Tasa de respuesta
            double responseRate = Q1Results.NumberResponded / Q1Results.NumberSurveyed;
            //Encuestas sin respuesta
            double unansweredCount = Q1Results.NumberSurveyed - Q1Results.NumberResponded;
            double overallScore = (Q1Results.ServiceScore + Q1Results.CoffeeScore + Q1Results.PriceScore + Q1Results.FoodScore) / 4;

            Console.WriteLine($"Response Percentage: {responseRate}");
            Console.WriteLine($"Unanswered Surveys: {unansweredCount}");
            Console.WriteLine($"Overall Score: {overallScore}");

            //Logical comparison
            bool higherCoffeeScore = Q1Results.CoffeeScore > Q1Results.FoodScore;
            bool customersRecommend = Q1Results.WouldRecommend >= 7;
            bool noGranolaYesCappucino = Q1Results.LeastFavoriteProduct == "Granola" && Q1Results.FavoriteProduct == "Cappucino";
            bool noGranolaYesCappucino2 = Q1Results.LeastFavoriteProduct.Equals("Granola") && Q1Results.FavoriteProduct.Equals("Cappucino");

            Console.WriteLine($"Coffe score Higher Than Food:  { higherCoffeeScore}");
            Console.WriteLine($"Customers Would Recommend Us:  { customersRecommend}");
            Console.WriteLine($"Hate Granola, Love Cappucino:  { noGranolaYesCappucino}");
            Console.WriteLine($"Hate Granola, Love Cappucino:  { noGranolaYesCappucino2}");

        }
    }
}
