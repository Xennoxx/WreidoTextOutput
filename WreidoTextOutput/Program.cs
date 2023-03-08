using WreidoTextOutput;

class program
{
    public void Main(string[] args)
    {
        PatternMenu MainMenu = new();
        MainMenu.PatternHeadLineMethod("Main Menu");
        MainMenu.PatternTextMethod("Wanna make wreido text?",1);
        MainMenu.PatternTextMethod("Wanna see what i replace?",2);
        MainMenu.PatternTextMethod("Wanna quit", 3);
        int MainInput = 0;
            MainInput = Convert.ToInt32(Console.ReadLine());

        if (MainInput == 1)
        {
            Crypt crypt = new();
            crypt.CryptInput = Convert.ToString(Console.ReadLine);
            /*Make you text converter here*/ 
        }
        else if (MainInput == 2) { /*Show what youre using*/}
        else if (MainInput == 3) { /*And quiting is here*/}
    }
}