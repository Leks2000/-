/* Задание 3.
var max = -100f;
Console.WriteLine("Введите числа: ");
var number = Console.ReadLine();
string[] nums = number.Split(new char[] { ' ' });
foreach (string num in nums)
{
    float num1 = float.Parse(num);
    if (max < num1)
    {
        max = num1;
    }
}
Console.WriteLine($"Максимальное число: {max}");
*/



/* Задание 4
    int result = 0;
    var quan = Console.ReadLine();
    int[] count = new int[10];
    int i = 0;
    if (int.TryParse(quan, out int n))
    {
        do
        {
            result = n % 10;
            count[i] = result;
            n /= 10;
            i++;

        } while (n > 0);
        i--;
        for (; i > 0;i--)
        {
            Console.WriteLine($"{count[i]},");
        }
    Console.WriteLine($"{count[i]}");
}
*/

/* Задание 5
Console.WriteLine("Введите знакопеременный ряд через пробел: ");
var exp = Console.ReadLine();
string[] e = exp.Split (new char[] { ' ' });
int sum = 0; 
foreach(string n in e)
{
    int num = int.Parse(n);
    sum += num;
}
Console.WriteLine($"Сумма знакопеременного ряда: {sum}");
*/