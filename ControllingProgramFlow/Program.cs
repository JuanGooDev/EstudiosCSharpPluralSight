namespace ControllingProgramFlow
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            bool quitApp = false;

            do
            {
                Console.WriteLine("Please specify a report to run (rewards, comments, tasks, quit): ");
                var selectedReport = Console.ReadLine();

                Console.WriteLine("Please specify which quarter of data: (q1, q2)");
                var selectedFile = Console.ReadLine();

                var surveyResults = SurveyDataService.GetSurveyDataByFileName(selectedFile);

                switch (selectedReport)
                {
                    case "rewards":
                        RewardsReportService.GenerateWinnerEmails(surveyResults);
                        break;
                    case "comments":
                        CommentsReportService.GenerateCommentsReport(surveyResults);
                        break;
                    case "tasks":
                        TasksReportService.GenerateTasksReport(surveyResults);
                        break;
                    case "quit":
                        quitApp = true;
                        break;
                    default:
                        Console.WriteLine("Sorry, that's not a valid option.");
                        break;
                }

                Console.WriteLine();
            } 
            while (!quitApp);


        }

        public static void GenerateWinnerEmails(SurveyResults results)
        {
            var selectedEmails = new List<string>();
            int counter = 0;

            Console.WriteLine(Environment.NewLine + "Selected Winners Output");
            while (selectedEmails.Count < 2 && counter < results.Responses.Count)
            {
                var currentItem = results.Responses[counter];

                if (currentItem.FavoriteProduct == "Cappucino")
                {
                    selectedEmails.Add(currentItem.EmailAddress);
                    Console.WriteLine(currentItem.EmailAddress);
                }

                counter++;
            }

            File.WriteAllLines("WinnersReport.csv", selectedEmails);
        }

        public static void GenerateCommentsReport(SurveyResults results)
        {
            var comments = new List<string>();

            Console.WriteLine(Environment.NewLine + "Comments Outpu");
            for (int i = 0; i < results.Responses.Count; i++)
            {
                var currentResponse = results.Responses[i];

                if (currentResponse.WouldRecommend < 7.0)
                {
                    Console.WriteLine(currentResponse.Comments);
                    comments.Add(currentResponse.Comments);
                }

            }

            foreach (var response in results.Responses)
            {
                if (response.AreaToImprove == results.AreaToImprove)
                {
                    Console.WriteLine(response.Comments);
                    comments.Add(response.Comments);
                }
            }

            File.WriteAllLines("CommentsReport.csv", comments);
        }

        public static void GenerateTasksReport(SurveyResults results)
        {
            var tasks = new List<string>();

            //Tasa de respuesta
            double responseRate = results.NumberResponded / results.NumberSurveyed;
            double overallScore = (results.ServiceScore + results.CoffeeScore + results.PriceScore + results.FoodScore) / 4;

            //Logical comparison
            if (results.CoffeeScore < results.FoodScore)
            {
                tasks.Add("Investigate coffe recipes and ingredients");
            }

            //Forma ternaria de definir el if de abajo            
            tasks.Add(overallScore > 8.0 ? "Work with leadership to reward staff." : "Work with employees for improvement ideas.");

            /*
            if (overallScore > 8.0)
            {
                tasks.Add("Work with leadership to reward staff");
            }
            else
            {
                tasks.Add("Work with employees for improvement ideas");
            }*/

            //Forma nueva de realizar la sentencia if else de abajo
            tasks.Add(responseRate switch
            {
                var rate when rate < .33 => "Research options to improve response rate.",
                var rate when rate > .33 && rate < .66 => "Reward participants with free coffe coupon.",
                var rate when rate > .66 => "Rewards participants with discount coffe coupon."
            });

            //Forma antigua de realizar esta tarea
            /*
            if (responseRate < .33)
            {
                tasks.Add("Research options to improve response rate.");
            }
            else if (responseRate > .33 && responseRate < .66)
            {
                tasks.Add("Reward participants with free coffe coupon");
            }
            else
            {
                tasks.Add("Rewards participants with discount coffe coupon.");
            }*/

            //Otra forma de realizar una sentencia Switch            
            tasks.Add(results.AreaToImprove switch
            {
                "RewardsProgram" => "Revisit the rewards deals.",
                "CleanLiness" => "Contact the leaning vendor.",
                "MobileApp" => "Contact consulting firm about app.",
                _ => "Investigate individual comments for ideas."
            });

            //Forma antigua de realizar un switch
            /*
            switch (results.AreaToImprove)
            {
                case "RewardsProgram":
                    tasks.Add("Revisit the rewards deals");
                    break;

                case "Cleanliness":
                    tasks.Add("Contact the cleaning vendor.");
                    break;

                case "MobileApp":
                    tasks.Add("Contact consulting firm about app.");
                    break;

                default:
                    tasks.Add("Investigate individual comments for ideas.");
                    break;
            }*/

            Console.WriteLine(Environment.NewLine + "Tasks Output");
            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }

            File.WriteAllLines("TasksReport.csv", tasks);
        }
    }
}
