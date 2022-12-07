namespace TextEncoderApp.Classes
{
    public class Area
    {
        public int Rows { get; set; }
        public int Columns { get; set; }

        public Area(int rows, int columns) 
        { 
            Rows = rows;
            Columns = columns;
        }
    }
}
