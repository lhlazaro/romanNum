internal class Program
{

    private static void Main(string[] args)
    {
        int number = 25;
        int loop = 0;
        List<string> romanNum = new();
        while (number > 0)
        {
            int currentValue = number % 10;
            number /= 10;
            loop++;
            if (loop == 1) romanNum.Add (GetUnidades(currentValue));
            if (loop == 2) romanNum.Add (GetDecenas(currentValue));
            if (loop == 3) romanNum.Add (GetCentenas(currentValue));
            if (loop == 4) romanNum.Add (GetMillar(currentValue));
        }
        romanNum.Reverse();
        Console.WriteLine(string.Join("",romanNum.ToArray()));  
    }
    public static string GetUnidades(int value)
    {
        return value switch
        {
            0 => "",
            1 => "I",
            2 => "II",
            3 => "III",
            4 => "IV",
            5 => "V",
            6 => "VI",
            7 => "VII",
            8 => "VIII",
            9 => "IX",
            _ => "",
        };
    }
    public static string GetDecenas(int value)
    {
        return value switch
        {
            0 => "",
            1 => "X",
            2 => "XX",
            3 => "XXX",
            4 => "XL",
            5 => "L",
            6 => "LX",
            7 => "LXX",
            8 => "LXXX",
            9 => "XC",
            _ => "",
        };
    }
    public static string GetCentenas(int value)
    {
        return value switch
        {
            0 => "",
            1 => "C",
            2 => "CC",
            3 => "CCC",
            4 => "DC",
            5 => "D",
            6 => "DC",
            7 => "DCC",
            8 => "DCCC",
            9 => "CM",
            _ => "",
        };
    }
    public static string GetMillar(int value)
    {
        return value switch
        {
            0 => "",
            1 => "M",
            2 => "MM",
            3 => "MMM",
            _ => "",
        };
    }

}