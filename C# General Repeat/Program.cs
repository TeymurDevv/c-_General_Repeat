#region task1
Console.WriteLine("4reqemli eded daxil edin");
int num1 = int.Parse(Console.ReadLine());
string num1String = num1.ToString();
while (true)
{
    if (num1String.Length == 4)
    {
        Console.WriteLine("7" + num1String + "8");
        break;
    }
    else
    {
        Console.WriteLine("Yanlış formatda eded daxil etdiniz. Yeniden daxil edin.");
        num1String = Console.ReadLine();
    }
}
#endregion
#region task2
Console.WriteLine(" 3 reqemli ededi daxil edin");
int num2 = int.Parse(Console.ReadLine());
string str2 = num2.ToString();
while (true)
{



    if (str2.Length == 3)
    {
        Console.WriteLine(str2 + str2);
        break;
    }
    else
    {
        Console.WriteLine("Yanlış formatda eded daxil etdiniz. Yeniden daxil edin.");
        str2 = Console.ReadLine();
    }
}
#endregion
#region task3
Console.WriteLine(" 5 reqemli ededi daxil edin");
int num3 = int.Parse(Console.ReadLine());
string str3 = num3.ToString();
while (true)
{
    if (str3.Length == 5)
    {
        double tempresult5 = (num3 * 0.18);
        double result5 = tempresult5 * 0.03;
        Console.WriteLine(result5);
        break;
    }
    else
    {
        Console.WriteLine("Yanlış formatda eded daxil etdiniz. Yeniden daxil edin.");
        str3 = Console.ReadLine();
    }
}
#endregion
#region task4
//4) 3 reqemli eded verilib. Bu ededin axirina 7 artir. Sonra cavabin 7% tap
Console.WriteLine("3 reqemli eded daxil edin");
int num4 = int.Parse(Console.ReadLine());
string str4 = num4.ToString();
while (true)
{
    if (str4.Length == 3) //yoxluyur gorur 3ludur
    {
        int numWith7 = num4 * 10 + 7;
        double numWith8 = numWith7 * 0.07;

        Console.WriteLine("Cavab: " + numWith8);
        break;
    }
    else
    {
        Console.WriteLine("Duzgun formatda eded daxil etmediniz.");
        str4 = Console.ReadLine();
    }
}
#endregion


