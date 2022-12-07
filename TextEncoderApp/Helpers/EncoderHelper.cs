using TextEncoderApp.Classes;

namespace TextEncoderApp.Helpers
{
    public class EncoderHelper
    {
        public static string GetEncodedText(string text)
        {
            int L = text.Length;

            Area tableArea = GetArea(L);

            List<string> table = GetTable(tableArea, text);

            string[] encriptedTable = Enumerable.Repeat(string.Empty, tableArea.Columns).ToArray();

            foreach(string word in table)
            {
                int length = word.Length;

                char[] charArray = word.ToCharArray();

                for (int i = 0; i < length; i++)
                {
                    encriptedTable[i] += charArray[i].ToString();
                }
            }

            return string.Join(" ", encriptedTable);
        }

        private static List<string> GetTable(Area area, string text)
        {
            List<string> table = new List<string>();

            int startPosition = 0;

            for (int i = 1; i <= area.Rows; i++)
            {
                int stringLength = text.Length - startPosition >= area.Columns ? area.Columns : text.Length - startPosition;

                table.Add(text.Substring(startPosition, stringLength));

                startPosition = area.Columns * i;
            }

            return table;
        }

        private static Area GetArea(int lenght)
        {
            double sqrtL = Math.Sqrt(lenght);

            int minRows = Convert.ToInt32(Math.Floor(sqrtL));

            int maxColumns = Convert.ToInt32(Math.Ceiling(sqrtL));

            if(minRows * maxColumns >= lenght) 
                return new Area(minRows, maxColumns);
            else
                return new Area(maxColumns, maxColumns);
        }
    }
}
