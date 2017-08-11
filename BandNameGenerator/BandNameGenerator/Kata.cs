namespace BandNameGenerator
{
    public class Kata
    {
        public static string BandNameGenerator(string str)
        {
            var firstCharacter = str.Substring(0,1);
            var lastCharacter = str.Substring(str.Length-1);
            var upperStr = GetFirstLetterToUpper(str);

            if (firstCharacter == lastCharacter)
            {
                return upperStr + upperStr.Substring(1, str.Length-1);
            }

            return ("The " + upperStr);
        }

        private static string GetFirstLetterToUpper(string str)
        {
            return str.Substring(0, 1).ToUpper() + str.Substring(1);
        }
    }
}