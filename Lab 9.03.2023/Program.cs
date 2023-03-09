using System;
using System.Data;

static int BinarySearch(int[] mass, int value)
{
    int left = 0;
    int right = Length(mass) - 1;
    if (left == right)
        return left;
    while (true)
    {
        if (right - left == 1)
        {
            if (mass[left].CompareTo(value) == 0)
                return left;
            if (mass[right].CompareTo(value) == 0)
                return right;
            return -1;
        }
        else
        {
            var middle = left + (right - left) / 2;
            var comparisonResult = mass[middle].CompareTo(value);
            if (comparisonResult == 0)
                return middle;
            if (comparisonResult < 0)
                left = middle;
            if (comparisonResult > 0)
                right = middle;
        }
    }
}

static int[] Sort(int[] mass)
{
    var done = false;
    while (!done)
    {
        done = true;
        for (var i = 1; i < Length(mass); i += 1)
        {
            if (mass[i - 1] > mass[i])
            {
                done = false;
                var tmp = mass[i - 1];
                mass[i - 1] = mass[i];
                mass[i] = tmp;
            }
        }
    }

    return mass;
}

static int[] Copy(int[] mass, int[] copy_mass)
{
    for (int i =0;i<Length(mass);i++)
    {
        copy_mass[i] = mass[i];
    }
    return copy_mass;
}

static int[] Reverse(int[] mass)
{
    int tmp = 0;
    for (int i = 0; i<Length(mass);i++)
    {
        tmp = mass[i];
        mass[i] = mass[Length(mass)-i];
        mass[Length(mass)-i] = tmp;
    }
    return mass;
}

static int Length(int[] mass)
{
    int n = 0;
    try{
        while (true)
        {
            int k = mass[n];
            n++;
        }
    }

    catch(IndexOutOfRangeException) {
        return n+1;
    }
}

static string ToString(int[] mass)
{
    string str = "";
    for (int i =0; i<Length(mass);i++)
    {
        str = str + mass[i];
    }
    return str;
}

static int[] SetValue(int[] mass, int value)
{
    int k = Convert.ToInt32(Console.ReadLine());
    mass[k] = value;
    return mass;
}

static int IndexOf(int[] mass, int value)
{
    for (int i=0;i<Length(mass);i++)
    {
        if (mass[i]==value)
        {
            return mass[i];
        }
    }
    return -1;
}

static bool Exist(int[] mass, int value)
{
    for (int i = 0; i < Length(mass); i++)
    {
        if (mass[i] == value)
        {
            return true;
        }
    }
    return false;
}

static int[] Clear(int[] mass)
{
    int[] newmass = new int[Length(mass)];
    return newmass;
}

int n = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[n];
int[] copy_mass = new int[n];
while (true) {
    Console.WriteLine("1.  BinarySearch");
    Console.WriteLine("2.  Sort");
    Console.WriteLine("3.  Copy");
    Console.WriteLine("4.  Reverse");
    Console.WriteLine("5.  Lenght");
    Console.WriteLine("6.  ToString");
    Console.WriteLine("7.  SetValue");
    Console.WriteLine("8.  IndexOf");
    Console.WriteLine("9.  Exist");
    Console.WriteLine("10. Clear");
    Console.WriteLine("11. Exit");
    int command = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    if (command == 1)
    {
        int value = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(BinarySearch(mass, value));
    }
    if (command == 2)
    {
        mass = Sort(mass);
    }
    if (command == 3)
    {
        mass = Copy(mass, copy_mass);
    }
    if (command == 4)
    {
        mass = Reverse(mass);
    }
    if (command == 5)
    {
        Console.WriteLine(Length(mass));
    }
    if (command == 6)
    {
        Console.WriteLine(ToString(mass));
    }
    if (command == 7)
    {
        int value = Convert.ToInt32(Console.ReadLine());
        mass = SetValue(mass, value);
    }
    if (command == 8)
    {
        int value = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(IndexOf(mass, value));
    }
    if (command == 9)
    {
        int value = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Exist(mass, value));
    }
    if (command == 10)
    {
        mass = Clear(mass);
    }
    if (command == 11)
    {
        break;
    }
    Console.ReadLine();
    Console.Clear();

    for (int i = 0; i< n; i++)
    {
        Console.WriteLine(mass[i]);
    }
}