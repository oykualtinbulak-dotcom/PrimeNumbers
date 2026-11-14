Console.Write("Sayı Giriniz: ");
int number = Convert.ToInt32(Console.ReadLine());
bool prime = true;
if(number == 2)
{
    Console.Write("Sayı asal sayıdır.");
}
else
{
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
        {
            prime = false;
            break;
        }
    }
    if( prime == true)
    {
        Console.Write("Sayı asaldır.");
    }
    else
    {
        Console.Write("Sayı asal değildir.");
    }
}

