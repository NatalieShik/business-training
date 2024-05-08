namespace BusinessTraining.Configuration.Logic
{
    public static class ValidationHelper
    {
        private const int MinPasswordLength = 6;
        public static CheckStatus CheckPassword(string password, string pseudoPassword)
        {
            if (password == pseudoPassword)
                return CheckStatus.Success;

            if (password.Length < MinPasswordLength)
                return CheckStatus.WrongLength;

            bool hasUpperCase = false;
            bool hasLowerCase = false;
            bool hasDigit = false;
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                    hasUpperCase = true;
                else if (char.IsLower(c))
                    hasLowerCase = true;
                else if (char.IsDigit(c))
                    hasDigit = true;
            }

            if (!hasUpperCase || !hasLowerCase || !hasDigit)
                return CheckStatus.SymbolsProblem;
            return CheckStatus.Success;
        }
    }
}
