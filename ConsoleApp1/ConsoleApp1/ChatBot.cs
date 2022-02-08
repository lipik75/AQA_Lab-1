namespace ConsoleApp1;

public class ChatBot
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Здравствуйте! Введите вашу фамилию.");
        var secondName = Console.ReadLine();
        
        Console.WriteLine("Введите ваше имя.");
        var firstName = Console.ReadLine();
        
        Console.WriteLine("Введите дату приема в формате дд/мм/гггг");
        var date = Console.ReadLine();
        
        Console.WriteLine("{0} {1}, Вы записаны на прием {2}.", secondName, firstName, date);

    }
}