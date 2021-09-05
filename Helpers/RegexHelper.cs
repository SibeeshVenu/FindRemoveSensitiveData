using System.Text;
using System.Text.RegularExpressions;

namespace FindRemoveSensitiveData.Helpers
{
    public abstract class RegexHelper
    {
        private readonly string _regexExpression;
        private readonly string _replacementString;
        public RegexHelper(string regexExpression, string replacementString)
        {
            _regexExpression = regexExpression;
            _replacementString = replacementString;
        }
        public string ModifyString(string strToModify)
        {
            var splittedArray = strToModify.Split(" ");
            var strBuilder = new StringBuilder();
            foreach (var arr in splittedArray)
            {
                strBuilder.Append($"{Regex.Replace(arr, _regexExpression, _replacementString)} ");
            }
            return strBuilder.ToString();
        }
    }
}
