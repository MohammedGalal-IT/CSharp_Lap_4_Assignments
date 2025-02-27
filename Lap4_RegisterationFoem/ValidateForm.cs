namespace Lap4_RegisterationFoem
{
    class ValidateForm
    {
        public static bool CheckTextEmpty(string text)
        {
            if (text.Trim() == "" || text == null)
            {
                return true;
            }

            return false;
        }

        public static bool IsPasswordStrong(string password)
        {
            if (password.Length > 8)
            {
                return true;
            }

            return false;
        }
        //public static bool CheckEmailIsValid(string email)
        //{
        //    if()
        //}
    }
}
