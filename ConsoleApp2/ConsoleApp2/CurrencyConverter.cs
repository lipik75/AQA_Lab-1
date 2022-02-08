namespace ConsoleApp1;

public class CurrencyConverter
{
    static void Main(string[] args)
        {
            double byn;
            double usd;
            double eur;
            double bynBuyUsd = 2.5712, bynBuyEur = 2.9314, usdBuyEur = 0.88;
            float currencyCount;

            string word = "Вас приветствует наш обменный пункт.";

            Console.WriteLine(word);
            Console.Write("Укажите ваш баланс в белорусских рублях: ");
            byn = Convert.ToSingle(Console.ReadLine());
            Console.Write("Укажите ваш баланс в долларах: ");
            usd = Convert.ToSingle(Console.ReadLine());
            Console.Write("Укажите ваш баланс в евро: ");
            eur = Convert.ToSingle(Console.ReadLine());

            while (word != "7")
            {
                Console.WriteLine("Выберете валюту для обмена.");
                Console.WriteLine("1 - обменять рубли на доллары.");
                Console.WriteLine("2 - обменять рубли на евро.");
                Console.WriteLine("3 - обменять доллары на рубли.");
                Console.WriteLine("4 - обменять доллары на евро.");
                Console.WriteLine("5 - обменять евро на рубли.");
                Console.WriteLine("6 - обменять евро на доллары.");
                Console.WriteLine("7 - выход из программы");
                word = Console.ReadLine();

                switch(word)
                {
                    case "1":
                        Console.WriteLine("Обмен рублей на доллары.");
                        Console.Write("Введите сумму: ");
                        currencyCount = Convert.ToSingle (Console.ReadLine());
                        if (byn >= currencyCount)
                        {
                            byn -= currencyCount;
                            usd += currencyCount / bynBuyUsd;
                        }
                        else
                        {
                            Console.WriteLine("На вашем балансе недостаточно средств!");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Обмен рублей на евро.");
                        Console.Write("Введите сумму: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (byn >= currencyCount)
                        {
                            byn -= currencyCount;
                            eur += currencyCount / bynBuyEur;
                        }
                        else
                        {
                            Console.WriteLine("На вашем балансе недостаточно средств!");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Обмен долларов на рубли.");
                        Console.Write("Введите сумму: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (usd >= currencyCount)
                        {
                            usd -= currencyCount;
                            byn += currencyCount * bynBuyUsd;
                        }
                        else
                        {
                            Console.WriteLine("На вашем балансе недостаточно средств!");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Обмен долларов на евро.");
                        Console.Write("Введите сумму: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (usd >= currencyCount)
                        {
                            usd -= currencyCount;
                            eur += currencyCount / usdBuyEur;
                        }
                        else
                        {
                            Console.WriteLine("На вашем балансе недостаточно средств!");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Обмен евро на рубли.");
                        Console.Write("Введите сумму: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (eur >= currencyCount)
                        {
                            eur -= currencyCount;
                            byn += currencyCount * bynBuyEur;
                        }
                        else
                        {
                            Console.WriteLine("На вашем балансе недостаточно средств!");
                        }
                        break;
                    case "6":
                        Console.WriteLine("Обмен евро на доллары.");
                        Console.Write("Введите сумму: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (eur >= currencyCount)
                        {
                            eur -= currencyCount;
                            usd += currencyCount * usdBuyEur;
                        }
                        else
                        {
                            Console.WriteLine("На вашем балансе недостаточно средств!");
                        }
                        break;
                    case "7":
                        break;
                    default:
                        Console.WriteLine("!!!Некоректная команда!!!");
                        break;
                }

                Console.WriteLine("Ваш баланс составляет: " + Math.Round(byn, 2) + " рублей, " + Math.Round(usd, 2) + " долларов, " + Math.Round(eur, 2) + " евро.");
            }
            
        }
}