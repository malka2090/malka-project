namespace malka_Project
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to cyber collage.");
            Console.WriteLine("what can i do for you?");
            Console.WriteLine();
            AppConsole ReturnPick = new AppConsole();
            ReturnPick.GetUserPick();


                switch (pick)
            {
                case 1:
                    Student MyData = new Student();
                    MyData.GetUserInput();
                    break;
                
            }
            


        }
    }
}


