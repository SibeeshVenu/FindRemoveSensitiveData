namespace FindRemoveSensitiveData.Helpers
{
    public class EmailRegexHelper : RegexHelper
    {
        const string regexExpression = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        const string replacementString = "<EMAIL>";
        public EmailRegexHelper() : base(regexExpression, replacementString) { }
    }
}
