using FindRemoveSensitiveData.Helpers;
using System;
using Newtonsoft.Json;
using FindRemoveSensitiveData.Models;
using System.Linq;
using System.Threading.Tasks;

namespace FindRemoveSensitiveData
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var answers = await JsonHelper.ReadFileAsync<AnswerModel[]>("data.json");
            answers.ToList().ForEach(async answer => await FormatData(answer));
            Console.ReadLine();
        }

        private static Task FormatData(AnswerModel answerModel)
        {
            RegexHelper regexHelper = new EmailRegexHelper();
            var withoutEmail = regexHelper.ModifyString(answerModel.Answer);
            regexHelper = new IpAddressRegexHelper();
            Console.WriteLine(regexHelper.ModifyString(withoutEmail));
            return Task.CompletedTask;

        }
    }
}
