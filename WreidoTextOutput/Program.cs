using WreidoTextOutput;

class Program
{
    public static void Main(string[] args)
    {
        bool Check = true;
        do
        {
            PatternMenu MainMenu = new();
            MainMenu.PatternHeadLineMethod("Main Menu");
            MainMenu.PatternTextMethod("Wanna make wreido text?", 1);
            MainMenu.PatternTextMethod("Wanna quit", 2);
            int MainInput = 0;
                MainInput = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (MainInput == 1)
            {
                Console.WriteLine("Write you sentence");
                Crypt _crypt = new();
                _crypt.Crypting(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("xX_" + _crypt.PersonalUnlock + "_Xx");
                Thread.Sleep(5000);
            }
            else if (MainInput == 2) { Check = false; }
            else
            {
                Console.WriteLine("Error: Number is not valied");
            }
        } while (Check == true);
    }
}