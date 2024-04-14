//task0
using System.Runtime.InteropServices;

Console.WriteLine("TASK0");
Console.WriteLine("Eded daxil edin");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    Console.WriteLine("musbetdir");
}
else if (number < 0)
{
    Console.WriteLine("menfidir");
}
else
{
    Console.WriteLine("0-a beraberdir");
}

//task1
Console.WriteLine("TASK1");
int sum = 0;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("eded daxil edin");
    int number1 = Convert.ToInt32(Console.ReadLine());
    sum += number1;
}

Console.WriteLine(sum);

//task2
Console.WriteLine("TASK2");
Console.WriteLine("eded daxil edin");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number2 * number2);

//task3
Console.WriteLine("TASK3");
Console.WriteLine("3 eded daxil edin");
int number3_1 = Convert.ToInt32(Console.ReadLine());
int number3_2 = Convert.ToInt32(Console.ReadLine());
int number3_3 = Convert.ToInt32(Console.ReadLine());
if ((number3_1 >= number3_2) && (number3_1 >= number3_2))
{
    Console.WriteLine(number3_1);
}
else if ((number3_2 >= number3_1) && (number3_2 >= number3_3))
{
    Console.WriteLine(number3_2);
}
else if ((number3_3 >= number3_1) && (number3_3 >= number3_2))
{
    Console.WriteLine(number3_3);
}

//task4
Console.WriteLine("TASK4");
int number4_1 = Convert.ToInt32(Console.ReadLine());
int number4_2 = Convert.ToInt32(Console.ReadLine());
if (number4_1 * number4_1 * number4_1 > number4_2)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}

//task5
Console.WriteLine("TASK5");
int number5 = Convert.ToInt32(Console.ReadLine());
if (number5 % 3 == 0 && number5 % 5 == 0)
{
    Console.WriteLine("Bolunur");
}
else
{
    Console.WriteLine("Bolunmur");
}


//task6
Console.WriteLine("TASK6");
int mebleg = Convert.ToInt32(Console.ReadLine());
int qiymet = Convert.ToInt32(Console.ReadLine());
if (mebleg >= qiymet)
{
    Console.WriteLine("Catir");
}
else
{
    Console.WriteLine("Catmir");
}

Console.WriteLine("TASK7");
int tam_bal = 0;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Bal daxil edin");
    int bal = Convert.ToInt32(Console.ReadLine());
    if (bal < 0 || bal > 100)
    {
        Console.WriteLine("Daxil etdiyiniz bal duzgun deyil, yeniden daxil edin");
        bal = Convert.ToInt32(Console.ReadLine());
    }
    tam_bal += bal;
}
if (tam_bal / 5 > 65)
{
    Console.WriteLine("Siz imtahandan kecmisiniz");
}
else
{
    Console.WriteLine("Siz kesilmisiniz");
}

//task8
Console.WriteLine("TASK8");
int number8_1 = Convert.ToInt32(Console.ReadLine());
int number8_2 = Convert.ToInt32(Console.ReadLine());
if (number8_1 > number8_2)
{
    Console.WriteLine("Birinci eded boyukdur");
}
else if (number8_1 < number8_2)
{
    Console.WriteLine("Ikinci eded boyukdur");
}
else
{
    Console.WriteLine("Ededler beraberdir");
}


//task9
Console.WriteLine("TASK9");
int temperature = Convert.ToInt32(Console.ReadLine());
if (temperature > 0)
{
    Console.WriteLine("Temperatur suyun donma temperaturundan yuxaridir");
}
else if (temperature < 0)
{
    Console.WriteLine("Temperatur suyun donma temperaturundan asagidir");
}
else
{
    Console.WriteLine("Temperatur suyun donma temperaturuna beraberdir");
}



Console.WriteLine("tasks part2");

Console.WriteLine("part2 task1");

for (int i = 0; i <= 50; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("part2 task2");
int count_task2 = 0;
for (int i = 0; i <= 40; i++)
{
    if (i % 3 == 0)
    {
        count_task2++;
    }
}
Console.WriteLine(count_task2);

Console.WriteLine("part2 task3");
int count_task3 = 0;
for (int i = 0; i <= 100; i++)
{
    if (i % 3 == 0 && i % 7 == 0)
    {
        count_task3++;
    }
}
Console.WriteLine(count_task3);

Console.WriteLine("part2 task4");
int count_task4 = 0;
int number2_4 = Convert.ToInt32(Console.ReadLine());
while (number2_4 > 0)
{
    count_task4++;
    number2_4 /= 10;

}
Console.WriteLine(count_task4);

Console.WriteLine("part2 task5");
int number2_5 = Convert.ToInt32(Console.ReadLine());
int reversed = 0;
while (number2_5 > 0)
{
    reversed = reversed * 10 + number2_5 % 10;
    number2_5 /= 10;
}
Console.WriteLine(reversed);

Console.WriteLine("part2 task6");
int factorial = 1;
int number2_6 = Convert.ToInt32(Console.ReadLine());
while (number2_6 > 0)
{
    factorial = factorial * number2_6;
    number2_6--;
}
Console.WriteLine(factorial);

Console.WriteLine("part2 task7");
int number2_7 = Convert.ToInt32(Console.ReadLine());
int kok_alti = Convert.ToInt32(Math.Sqrt(number2_7));
int lamp = 0;
for (int i = 2; i <= kok_alti; i++)
{
    if (number2_7 % i == 0)
    {
        Console.WriteLine("murekkeb ededdir");
        lamp = 1;
        break;
    }

}

if (lamp == 0)
{
    Console.WriteLine("sade ededdir");
}

Console.WriteLine("Part2 task8");
int number2_8 = Convert.ToInt32(Console.ReadLine());
int sum2_8 = 0;
while (number2_8 > 0)
{
    sum2_8 = sum2_8 + number2_8 % 10;
    number2_8 /= 10;
}
Console.WriteLine(sum2_8);

Console.WriteLine("part2 task9");
int number2_9 = Convert.ToInt32(Console.ReadLine());
int max = 0;
while (number2_9 > 0)
{
    if (number2_9 % 10 > max)
    {
        max = number2_9 % 10;
    }
    number2_9 /= 10;
}
Console.WriteLine(max);

Console.WriteLine("Part2 task10");
for (int i = 70; i >= 0; i -= 2)
{
    Console.WriteLine(i);
}



Console.WriteLine("part2 task11");
int ay = Convert.ToInt32(Console.ReadLine());
switch (ay)
{
    case 1:
    case 2:
    case 12:
        Console.WriteLine("qis");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("yaz");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("yay");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("payiz");
        break;

    default:
        Console.WriteLine("yalnis reqem daxil etdiniz");
        break;
}



//Ulduz suallari
Console.WriteLine("ulduz1");

int n11 = Convert.ToInt32(Console.ReadLine());
int n12 = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n11; i++)
{
    for (int j = 1; j < n12; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine("*");
}

Console.WriteLine("ulduz2");
int n2 = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n2; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine("*");
}

Console.WriteLine("ulduz3");
int n3 = Convert.ToInt32(Console.ReadLine());
for (int i = n3; i > 0; i--)
{
    for (int j = i - 1; j > 0; j--)
    {
        Console.Write("*");
    }
    Console.WriteLine("*");
}