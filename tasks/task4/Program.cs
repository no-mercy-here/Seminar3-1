//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Enter number one");
string enteredNumber1 = Console.ReadLine();
int a = Convert.ToInt32(enteredNumber1);
Console.WriteLine("Entern number two");
string enteredNumber2 = Console.ReadLine();
int b = Convert.ToInt32(enteredNumber2);
Console.WriteLine("Entern number three");
string enteredNumber3 = Console.ReadLine();
int c = Convert.ToInt32(enteredNumber3);
int max = a;

if (max < b) {
    max = b;
}
if (max < c) {
    max = c;
}
Console.WriteLine(max);