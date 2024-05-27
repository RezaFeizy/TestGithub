Test();

void Test()
{
    int[] numbers = new int[5];
    for (int i = 0; i < numbers.Length; i++)
    {
        int input = int.Parse(Console.ReadLine());
        numbers[i] = input;
    }

    int max = int.MinValue;
    int min = int.MaxValue;
    /*
     2
    4
    6
    1
    -11
     */
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
            max = numbers[i];
        if (numbers[i] < min)
            min = numbers[i];
    }

    Console.WriteLine(max);
    Console.WriteLine(min);
}

void MM2(String str)
{
    switch (str)
    {
        case "Zero":
            Console.WriteLine(0);
            break;
        case "One":
            Console.WriteLine(1);
            break;
        case "Two":
            Console.WriteLine(2);
            break;
        case "Three":
            Console.WriteLine(3);
            break;
        case "Four":
            Console.WriteLine(4);
            break;
        case "Five":
            Console.WriteLine(5);
            break;
        case "Six":
            Console.WriteLine(6);
            break;
        case "Seven":
            Console.WriteLine(7);
            break;
        case "Eight":
            Console.WriteLine(8);
            break;
        case "Nine":
            Console.WriteLine(9);
            break;
    }
}

void MM(int number)
{
    switch (number)
    {
        case 0:
            Console.WriteLine("Zero");
            break;
        case 1:
            Console.WriteLine("One");
            break;
        case 2:
            Console.WriteLine("Two");
            break;
        case 3:
            Console.WriteLine("Three");
            break;
        case 4:
            Console.WriteLine("Four");
            break;
        case 5:
            Console.WriteLine("Five");
            break;
        case 6:
            Console.WriteLine("Six");
            break;
        case 7:
            Console.WriteLine("Seven");
            break;
        case 8:
            Console.WriteLine("Eight");
            break;
        case 9:
            Console.WriteLine("Nine");
            break;
    }
}

void Sum(int a, int b)
{
    int c = a + b;
    Console.WriteLine(c);
}

void Multiplication(int a, int b)
{
    int c = a * b;
    Console.WriteLine(c);
}

void Divide(int a, int b)
{
    int c = a / b;
    Console.WriteLine(c);
}

void Subtraction(int a, int b)
{
    int c = a - b;
    Console.WriteLine(c);
}

void Print(String name, int age)
{
    Console.WriteLine("Your name is: " + name);
    Console.WriteLine("Your age is: " + age);
}