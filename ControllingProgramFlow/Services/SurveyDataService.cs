using Newtonsoft.Json;
using System.IO;

namespace ControllingProgramFlow
{
    class SurveyDataService
    {
        public static SurveyResults GetSurveyDataByFileName(string fileName)
        {
            return JsonConvert.DeserializeObject<SurveyResults>
                    (File.ReadAllText($"data/{fileName}.json"));
        }
    }
}
