#region
/*
// 1 Begin
/*double a = double.Parse(Console.ReadLine()!);
double b = double.Parse(Console.ReadLine()!);
double md = (a + b) / 2;
Console.WriteLine(md);
*//*

// 2 Begin
*//*
int a = int.Parse(Console.ReadLine()!);
int sum = 0, ml = 1;
while (a != 0)
{
    sum += a % 10;
    ml *= a % 10;
    a = a / 10;
}
Console.WriteLine(sum);
Console.WriteLine(ml);*//*

// 3 Integer
*//*int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);
int cnt = 0;
if (a > 0) { cnt++; }
if (b > 0) { cnt++; }
if (c > 0) { cnt++; }

Console.WriteLine(cnt);*//*


// 4 switch
*//*int a = int.Parse(Console.ReadLine()!);
string ans = a switch
{
    1 => "yomon",
    2 => "qoniqarsiz",
    3 => "qoniqarli",
    4 => "yaxshi",
    5 => "a'lo",
    _ => "xato"
};
Console.WriteLine(ans);*//*

// 5 while
*//*
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int sum = 0;
while (a < b)
{
    sum += a;
    a++;
}
Console.WriteLine(sum);*//*

//  6 array
*//*int n = int.Parse(Console.ReadLine()!);
int[] ints = new int[n];

for (int i = 0; i < ints.Length; i++)
{
    ints[i] = int.Parse(Console.ReadLine()!);
}

bool isPlus = false;
for (int i = 0; i < n; i++)
{
    if (ints[i] > 0)
    {
        isPlus = true;
    }
}
if (isPlus)
{
    Console.WriteLine("True");
}
else { Console.WriteLine("False"); }*//*

// 7 array
*//*int n = int.Parse(Console.ReadLine()!);
int[] ints = new int[n];
for (int i = 0; i < ints.Length; i++)
{
    ints[i] = int.Parse(Console.ReadLine()!);
}
for  (int i = 1; i< ints.Length; i+=2)
{
    ints[i] *= 3;
}*//*

// 8 array 2d
*//*int m = int.Parse(Console.ReadLine()!);
int n = int.Parse(Console.ReadLine()!);
int[,] arr = new int[m, n];
Random random = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = random.Next(1, 9);
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int mn = arr[0, 0];
int i_indx = 0;

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (arr[i, j] < mn)
        {
            i_indx = i;
        }
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i_indx != i)
        {
            Console.Write(arr[i, j] + " ");
        }
    }
    Console.WriteLine();
}*//*

// 9 metod
*//*
void InvertDigits(int k)
{
    while (k != 0)
    {
        Console.Write(k%10);
        k /= 10;
    }
}

int k = int.Parse(Console.ReadLine()!);
InvertDigits(k);*//*

// 10 string 1

*//*string input = Console.ReadLine()!;
try
{
    int a = int.Parse(input);
    Console.WriteLine(1);
}
catch
{
    try
    {
        double a = double.Parse(input);
        Console.WriteLine(2);
    }
    catch
    {
        Console.WriteLine(0);
    }
}*//*

// 11 string 2

*//*string a = Console.ReadLine()!;
int b = int.Parse(a);
int sm = 0;
while (b != 0)
{
    sm += b % 10;
    b = b / 10;
}
Console.WriteLine(sm);
*/

/*class Program
{
    static void Main()
    {

        int[,] matris = GetMatris();


        Console.WriteLine("Original matrix:");
        PrintMatris(matris);

        Console.WriteLine("Rotated matrix:");
        int[,] rotatedMatris = RotateMatris(matris);
        PrintMatris(rotatedMatris);
    }
    static int[,] RotateMatris(int[,] matris)
    {
        int n = matris.GetLength(0);
        int[,] rotatedMatris = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                rotatedMatris[j, n - 1 - i] = matris[i, j];
            }
        }

        return rotatedMatris;
    }

    static void PrintMatris(int[,] matris)
    {
        int n = matris.GetLength(0);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matris[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }

    static int[,] GetMatris()
    {
        Console.Write("Matrisning o'lchamini kiriting (N): ");
        int n = int.Parse(Console.ReadLine()!);

        int[,] matris = new int[n, n];

        Console.WriteLine($"{n}x{n} matris elementlarini kiriting:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"[{i + 1},{j + 1}] elementni kiriting: ");
                matris[i, j] = int.Parse(Console.ReadLine()!);
            }
        }

        return matris;
    }
}
*//*
//class Program
//{
//    static void Main()
//    {
//        int[,] matris = GetMatris();

//        Console.WriteLine("Original matrix: ");
//        PrintMatris(matris);

//        Console.WriteLine("Rotated matrix");
//        int[,] rotatedMatris = RotateMatrisCounterClockwise(matris);
//        PrintMatris(rotatedMatris);
//    }

//    static int[,] RotateMatrisCounterClockwise(int[,] matris)
//    {
//        int n = matris.GetLength(0);
//        int[,] rotatedMatris = new int[n, n];

//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                rotatedMatris[n - 1 - j, i] = matris[i, j];
//            }
//        }

//        return rotatedMatris;
//    }

//    static void PrintMatris(int[,] matris)
//    {
//        int n = matris.GetLength(0);

//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write(matris[i, j] + " ");
//            }
//            Console.WriteLine();
//        }

//        Console.WriteLine();
//    }

//    static int[,] GetMatris()
//    {
//        Console.Write("Matrisning o'lchamini kiriting (N): ");
//        int n = int.Parse(Console.ReadLine()!);

//        int[,] matris = new int[n, n];

//        Console.WriteLine($"{n}x{n} matris elementlarini kiriting:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write($"[{i + 1},{j + 1}] elementni kiriting: ");
//                matris[i, j] = int.Parse(Console.ReadLine()!);
//            }
//        }

//        return matris;
//    }
//}
*/
#endregion
Console.WriteLine("\t\t\t\t\tGUESS GAME");
Console.WriteLine("\t\t\t\tGuess a number game!");
Console.WriteLine("\t\t\t\tPlease press any key...");

Console.ReadKey();
Console.Clear();

place:
Console.WriteLine("1.   Computer");
Console.WriteLine("2.   Friends");
Console.Write("Please enetr your choice: ");
int cmd = int.Parse(Console.ReadLine()!);

switch (cmd)
{
    case 1:
        playWithComputer();
        break;
    case 2:
        playWithFriend();
        break;
    default:
        Console.WriteLine("Wrong input!");
        goto place;
}

void playWithComputer()
{
    Random random = new Random();
    int cnt = 0;
place_2:
    Console.WriteLine("1.   Finding a number");
    Console.WriteLine("2.   Computer finding a number");
    Console.Write("Please choose an option: ");
    int cmd = int.Parse(Console.ReadLine()!);
    switch (cmd)
    {
        case 1:
            Console.WriteLine("Computer has guessed a number between 1-10");
            int guess = random.Next(1, 10);
            bool isGuess = false;
            while (!isGuess)
            {
                Console.Write("Please input your number: ");
                int us = int.Parse(Console.ReadLine()!);
                cnt++;
                if (us == guess)
                {
                    isGuess = true;
                }
                else if (us > guess)
                {
                    Console.WriteLine("Input number is larger");
                }
                else
                {
                    Console.WriteLine("Input number is less");
                }
            }
            if (isGuess)
            {
                Console.WriteLine("Congratulations!!!");
                Console.WriteLine($"You found a number in {cnt} attemps");
            }
            Console.WriteLine("Would you like to play again(y/n) ?");
            char choice = Console.ReadLine()![0];
            if (choice == 'y')
            {
                goto place_2;
            }
            else
            {
                Console.WriteLine("Thanks for your game");
            }
            break;
        case 2:
            {
                Console.Write("Please enter a number between 1-10: ");
                int target = int.Parse(Console.ReadLine()!);
                bool isGame = false;
                int cnt_2 = 0;
                int start = 0;
                int stop = 10;
                while (!isGame)
                {

                    int a = random.Next(start, stop);
                    if (a == target)
                    {
                        Console.WriteLine($"Computer found your number in {cnt_2} attempts");
                        Console.WriteLine($"It is {a}");
                        isGame = true;
                    }
                    else
                    {
                        cnt_2++;
                        Console.WriteLine($"Your number is {a}?");
                        Console.WriteLine("(+) or (-) ?");
                        char res = Console.ReadLine()![0];

                        if (res == '+')
                        {
                            start = a + 1;
                        }
                        else
                        {
                            stop = a - 1;
                        }
                    }
                }
                Console.WriteLine("Would you like to play again(y/n) ?");
                char choice_2 = Console.ReadLine()![0];
                if (choice_2 == 'y')
                {
                    goto place_2;
                }
                else
                {
                    Console.WriteLine("Thanks for your game");
                }
                if (cnt > cnt_2)
                {
                    Console.WriteLine($"Computer won with {cnt - cnt_2}");
                }
                else
                {
                    Console.WriteLine("Player won");
                }
                Thread.Sleep(3000);
                break;
            }

        default:
            Console.WriteLine("Wrong input");
            goto place_2;
    }
}
void playWithFriend()
{
    Console.Write("Please input a name of first player: ");
    string user_1 = Console.ReadLine()!;
    Console.Write("Please input a name of second player: ");
    string user_2 = Console.ReadLine()!;
    Console.Write($"{user_1} please enter a number between 1-10: ");
    int num = int.Parse(Console.ReadLine()!);
    int cnt = 0;
    int cn = 0;
    bool isGame = false;
    while (!isGame)
    {
        Console.Write($"{user_2} please enter a number between 1-10: ");
        int guess = int.Parse(Console.ReadLine()!);
        cnt++;
        if (guess == num)
        {
            Console.WriteLine($"You found {user_1}'s number in {cnt} attemps!");
            isGame = true;
            break;
        }
        else if (guess > num)
        {
            Console.WriteLine("Your number is larger");
        }
        else
        {
            Console.WriteLine("Your number is less");
        }
    }
    Console.WriteLine("Would you like to play again(y/n) ?");
    char choice_2 = Console.ReadLine()![0];
    if (choice_2 == 'y')
    {
        Console.Write($"{user_2} please enter a number between 1-10: ");
        int nm = int.Parse(Console.ReadLine()!);
        bool isGam = false;
        while (!isGam)
        {
            Console.Write($"{user_1} please enter a number between 1-10: ");
            int guess = int.Parse(Console.ReadLine()!);
            cn++;
            if (guess == nm)
            {
                Console.WriteLine($"You found {user_1}'s number in {cn} attemps!");
                isGam = true;
                break;
            }
            else if (guess > nm)
            {
                Console.WriteLine("Your number is larger");
            }
            else
            {
                Console.WriteLine("Your number is less");
            }
        }
    }
    else
    {
        if (cnt > cn)
        {
            Console.WriteLine($"{user_1} won");
        }
        else
        {
            Console.WriteLine($"{user_2} won");
        }
    }
}