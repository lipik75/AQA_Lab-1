namespace ConsoleApp3;

public class Examples
{
    
    private bool x1 = true;
    private byte x2 = 5;		
    sbyte x3 = SByte.MaxValue;
    private char x4 = 'O';
    decimal x5 = Decimal.Zero;
    private double x6 = 4.57d;
    private float x7 = 3.2342342343f;
    private int x8 = 1234123123;	
    uint x9 = UInt32.MinValue;
    private long x10 = 991298912999999999;
    ulong x11 = UInt64.MaxValue;
    private short x12 = 3;
    private string x13 = "Some String";
    private Object x14 = null;
    
    
    
    public static void Main(string[] args)
    {
        //Постфиксный оператор приращения
        
        int i = 3;
        Console.WriteLine(i);   // output: 3
        Console.WriteLine(i++); // output: 3
        Console.WriteLine(i);   // output: 4
        
        //Префиксный оператор инкремента
        
        double a = 1.5;
        Console.WriteLine(a);   // output: 1.5
        Console.WriteLine(++a); // output: 2.5
        Console.WriteLine(a);   // output: 2.5
        
        //Постфиксный оператор уменьшения
        
        int e = 3;
        Console.WriteLine(e);   // output: 3
        Console.WriteLine(e--); // output: 3
        Console.WriteLine(e);   // output: 2
        
        //Префиксный оператор декремента
        
        double x = 1.5;
        Console.WriteLine(x);   // output: 1.5
        Console.WriteLine(--x); // output: 0.5
        Console.WriteLine(x);   // output: 0.5
        
        //Операторы унарного плюса и минуса
        
        Console.WriteLine(+4);     // output: 4

        Console.WriteLine(-4);     // output: -4
        Console.WriteLine(-(-4));  // output: 4

        uint aa = 5;
        var b = -aa;
        Console.WriteLine(b);            // output: -5
        Console.WriteLine(b.GetType());  // output: System.Int64

        Console.WriteLine(-double.NaN);  // output: NaN
        
        //Оператор умножения
        
        Console.WriteLine(5 * 2);         // output: 10
        Console.WriteLine(0.5 * 2.5);     // output: 1.25
        Console.WriteLine(0.1m * 23.4m);  // output: 2.34
        
        //Деление целых чисел
        
        Console.WriteLine(13 / 5);    // output: 2
        Console.WriteLine(-13 / 5);   // output: -2
        Console.WriteLine(13 / -5);   // output: -2
        Console.WriteLine(-13 / -5);  // output: 2
        
        //Деление чисел с плавающей запятой
        
        Console.WriteLine(16.8f / 4.1f);   // output: 4.097561
        Console.WriteLine(16.8d / 4.1d);   // output: 4.09756097560976
        Console.WriteLine(16.8m / 4.1m);   // output: 4.0975609756097560975609756098
        
        //Целочисленный остаток %
        
        Console.WriteLine(5 % 4);   // output: 1
        Console.WriteLine(5 % -4);  // output: 1
        Console.WriteLine(-5 % 4);  // output: -1
        Console.WriteLine(-5 % -4); // output: -1
        
        //Остаток с плавающей запятой %
        
        Console.WriteLine(-5.2f % 2.0f); // output: -1.2
        Console.WriteLine(5.9 % 3.1);    // output: 2.8
        Console.WriteLine(5.9m % 3.1m);  // output: 2.8
        
        //Оператор сложения
        
        Console.WriteLine(5 + 4);       // output: 9
        Console.WriteLine(5 + 4.3);     // output: 9.3
        Console.WriteLine(5.1m + 4.2m); // output: 9.3
        
        //Оператор вычитания
        
        Console.WriteLine(47 - 3);      // output: 44
        Console.WriteLine(5 - 4.3);     // output: 0.7
        Console.WriteLine(7.5m - 2.3m); // output: 5.2
        
        //Составное присваивание
        
        int aaa = 5;
        aaa += 9;
        Console.WriteLine(aaa);  // output: 14

        aaa -= 4;
        Console.WriteLine(aaa);  // output: 10

        aaa *= 2;
        Console.WriteLine(aaa);  // output: 20

        aaa /= 4;
        Console.WriteLine(aaa);  // output: 5

        aaa %= 3;
        Console.WriteLine(aaa);  // output: 2
        
        //Оператор логического отрицания !
        
        bool passed = false;
        Console.WriteLine(!passed);  // output: True
        Console.WriteLine(!true);    // output: False
        
        //Оператор логического И &
        
        bool SecondOperand()
        {
            Console.WriteLine("Second operand is evaluated.");
            return true;
        }

        bool ax = false & SecondOperand();
        Console.WriteLine(ax);
        // Output:
        //Second operand is evaluated.
        // False

        bool bx = true & SecondOperand();
        Console.WriteLine(bx);
        // Output:
        // Second operand is evaluated.
        // True
        
        //Оператор логического исключения ИЛИ ^
        
        Console.WriteLine(true ^ true);    // output: False
        Console.WriteLine(true ^ false);   // output: True
        Console.WriteLine(false ^ true);   // output: True
        Console.WriteLine(false ^ false);  // output: False
        
        //Оператор логического ИЛИ |
        
        bool SecondOperan()
        {
            Console.WriteLine("Second operand is evaluated.");
            return true;
        }

        bool aw = true | SecondOperan();
        Console.WriteLine(aw);
        // Output:
        // Second operand is evaluated.
        // True

        bool bw = false | SecondOperan();
        Console.WriteLine(bw);
        // Output:
        // Second operand is evaluated.
        // True
        
        //словный оператор логического И &&
        
        bool SecondOpera()
        {
            Console.WriteLine("Second operand is evaluated.");
            return true;
        }

        bool aq = false && SecondOpera();
        Console.WriteLine(aq);
        // Output:
        // False

        bool bq = true && SecondOpera();
        Console.WriteLine(bq);
        // Output:
        // Second operand is evaluated.
        // True
        
        //Условный оператор логического ИЛИ ||
        
        bool SecondOper()
        {
            Console.WriteLine("Second operand is evaluated.");
            return true;
        }

        bool ass = true || SecondOper();
        Console.WriteLine(ass);
        // Output:
        // True

        bool bs = false || SecondOper();
        Console.WriteLine(bs);
        // Output:
        // Second operand is evaluated.
        // True
        
        
        //Оператор равенства ==
        
        int ae = 1 + 2 + 3;
        int be = 6;
        Console.WriteLine(ae == be);  // output: True

        char c1 = 'a';
        char c2 = 'A';
        Console.WriteLine(c1 == c2);  // output: False
        Console.WriteLine(c1 == char.ToLower(c2));  // output: True
        
        //Оператор неравенства !=
        
        int a4 = 1 + 1 + 2 + 3;
        int b4 = 6;
        Console.WriteLine(a4 != b4);  // output: True

        string s1 = "Hello";
        string s2 = "Hello";
        Console.WriteLine(s1 != s2);  // output: False

        object o1 = 1;
        object o2 = 1;
        Console.WriteLine(o1 != o2);  // output: True
        
        //Оператор "меньше чем" <
        
        Console.WriteLine(7.0 < 5.1);   // output: False
        Console.WriteLine(5.1 < 5.1);   // output: False
        Console.WriteLine(0.0 < 5.1);   // output: True

        Console.WriteLine(double.NaN < 5.1);   // output: False
        Console.WriteLine(double.NaN >= 5.1);  // output: False
        
        //Оператор "больше чем" >
        
        Console.WriteLine(7.0 > 5.1);   // output: True
        Console.WriteLine(5.1 > 5.1);   // output: False
        Console.WriteLine(0.0 > 5.1);   // output: False

        Console.WriteLine(double.NaN > 5.1);   // output: False
        Console.WriteLine(double.NaN <= 5.1);  // output: False
        
        //Оператор "меньше или равно" <=
        
        Console.WriteLine(7.0 <= 5.1);   // output: False
        Console.WriteLine(5.1 <= 5.1);   // output: True
        Console.WriteLine(0.0 <= 5.1);   // output: True

        Console.WriteLine(double.NaN > 5.1);   // output: False
        Console.WriteLine(double.NaN <= 5.1);  // output: False
        
        //Оператор "больше или равно" >=
        
        Console.WriteLine(7.0 >= 5.1);   // output: True
        Console.WriteLine(5.1 >= 5.1);   // output: True
        Console.WriteLine(0.0 >= 5.1);   // output: False

        Console.WriteLine(double.NaN < 5.1);   // output: False
        Console.WriteLine(double.NaN >= 5.1);  // output: False
        
        //
        
        
        
        
        
    }
}