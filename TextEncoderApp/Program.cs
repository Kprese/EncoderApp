using TextEncoderApp.Helpers;

class Encoder
{
    static void Main()
    {
        bool restart = true;

        while(restart)
        {
            string text;

            Console.WriteLine("\nEnter Text To Encode: ");

            text = Console.ReadLine();

            if (text == null) return;

            string textWithoutSpaces = text.Replace(" ", "");

            Console.WriteLine($"\nResult: {EncoderHelper.GetEncodedText(textWithoutSpaces)}");

            Console.WriteLine("\nPress R to Restart or any other key to Exit\n");

            ConsoleKeyInfo key = Console.ReadKey();

            if (key.KeyChar.ToString().ToLower() != "r")
                restart = false;
        }
    }
}
