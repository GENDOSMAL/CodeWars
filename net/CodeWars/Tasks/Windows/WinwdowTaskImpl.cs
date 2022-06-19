using System.Text;

namespace Tasks.Windows
{
    public static class WinwdowTaskImpl
    {
        public static string MakeAWindow(int num)
        {
            var res = new StringBuilder();

            var baseStr= new string('.', num); 
            var floor = $"|{baseStr}|{baseStr}|";
            var startAndEnd = new string('-', floor.Length);
            res.Append(startAndEnd.AppendNewLine());
            for (int i = 0; i < num; i++)
            {
                res.Append(floor.AppendNewLine());
            }

            res.Append($"|{new string('-', num)}+{new string('-', num)}|".AppendNewLine());
            for (int i = 0; i < num; i++)
            {
                res.Append(floor.AppendNewLine());
            }
            res.Append(startAndEnd);

            return res.ToString();
        }

        private static string AppendNewLine(this string lineToAppend)
        {
            return $"{lineToAppend}\n";
        }
    }
}