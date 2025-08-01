using System.Globalization;

namespace Posts.Extensions
{
    internal static class PostExtension
    {
        public static string ElapsedTime(this DateTime moment)
        {
            TimeSpan duration = DateTime.Now.Subtract(moment);

            if (duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
            }
        }

        public static string Cut(this string sentence, int count)
        {
            if (sentence.Length <= count)
            {
                return sentence;
            }
            else
            {
                return sentence.Substring(0, count) + "...";
            }
        }
    }
}
