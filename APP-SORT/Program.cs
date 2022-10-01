using System.Text;
using System.Numerics;

var mass1 = new int[7];

var mass2 = WithRandInitialization(7);

var mass3 = new int[7];


Console.WriteLine("1 - ручной ввод");
Console.WriteLine("2 - автоматический подбор");
Console.WriteLine("Введите режим:");
var a1 = 0;
int.TryParse(Console.ReadLine(), out a1);



if (a1 == 1)
{
    
    for (int i1 = 0; i1 < 7; i1++)
    {
        Console.WriteLine($"Введите следующее значение:");
        var m0 = Console.ReadLine();
        int.TryParse(m0, out mass1[i1]);
        //Console.WriteLine(i1+1); //проверка вводимой позиции
    }

    Print(mass1, "Изначальный массив: ");
    mass3 = mass1;
}
else
{
    Print(mass2, "Изначальный массив: ");

    mass3 = mass2;
}


int[] WithRandInitialization(int dl1)
{
    var res1 = new int[dl1];
    var r1 = new Random();

    for (int i2 = 0; i2 < dl1; i2++)
    {
        res1[i2] = r1.Next(-99, 100);
    }

    return res1;
}


var kp = Sort(NaprSort.UP, mass3);
int Sort(NaprSort NaprSort, params int[] ar1)
{
    int kp = 0;
    for (var i3 = 0; i3 < ar1.Length - 1; i3++)
    {
        for (var j3 = i3 + 1; j3 < ar1.Length; j3++)
        {
            if (NaprSort == NaprSort.UP && ar1[i3] > ar1[j3])
            {
                Per(ref ar1[i3], ref ar1[j3]);
                kp++;
            }
            else if (NaprSort == NaprSort.DOWN && ar1[i3] < ar1[j3])
            {
                Per(ref ar1[i3], ref ar1[j3]);
                kp++;
            }
        }
    }
    return kp;

    static void Per(ref int a, ref int b)
    {
        var t = a;
        a = b;
        b = t;
    }
}


void Print(int[] ar1, string? prim = null)
{
    var txt = $"{prim} ".Trim();

    var s1 = new StringBuilder();
    foreach (var it in ar1)
    {
        s1.Append(" > ");
        s1.Append(it);
    }
    Console.WriteLine(txt + s1.ToString().TrimStart(','));
}


Print(mass3, "Конечный массив: ");
Console.WriteLine($"Количество перестановок: {kp}");
