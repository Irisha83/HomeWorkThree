// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Palindrome(int number)
{
    if (number < 100000 && number >= 10000)
    {
        if((number % 10) == (number/10000) && (number % 100)/10 == (number/1000)%10)
        {
            Console.Write("Ваше число: " + number + " палиндром");
        }
        else
        {
            Console.Write("Ваше число: " + number + " не палиндром");
        }
    }
    else
    {
      Console.Write("Вы ввели неверное число, необходимо ввести пятизначное");  
    }
}
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Palindrome (number);

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
 
// double Distance (double x1, double x2, double y1, double y2, double z1, double z2)
// {
// double a = ((x2 - x1)*(x2 - x1));
// double b = ((y2 - y1)*(y2 - y1));
// double c = ((z2 - z1)*(z2 - z1));
// double distance = Math.Sqrt(a + b + c);
// double result = Math.Round(distance,3);
// return result;
// }

// Console.WriteLine("Введите кординату х1: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите кординату y1: ");
// double y1 = Convert.ToDouble(Console.ReadLine());;
// Console.WriteLine("Введите кординату z1: ");
// double z1 = Convert.ToDouble(Console.ReadLine());;
// Console.WriteLine("Введите кординату х2: ");
// double x2 = Convert.ToDouble(Console.ReadLine());;
// Console.WriteLine("Введите кординату y2: ");
// double y2 = Convert.ToDouble(Console.ReadLine());;
// Console.WriteLine("Введите кординату z2: ");
// double z2 = Convert.ToDouble(Console.ReadLine());;

// double distance = Distance(x1, x2, y1, y2, z1, z2);
// Console.WriteLine($"Расстояние {distance}");

// 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// void ShowNumber(int num)
// {
//     int count = 1;
//     while (count <= num)
    
//     {   double n = Math.Pow(count,3);
//         count ++;
//         Console.Write(n + " ");
//     }
// }
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// ShowNumber (number);