//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Enter a number");
string enteredNumber1 = Console.ReadLine();
int number1 = Convert.ToInt32(enteredNumber1);
Console.WriteLine("Entern another number");
string enteredNumber2 = Console.ReadLine();
int number2 = Convert.ToInt32(enteredNumber2);

if (number1 > number2) {
    Console.WriteLine($"{enteredNumber1} is bigger than {enteredNumber2}");
    }
else if (number2 > number1) {
    Console.WriteLine($"{enteredNumber2} is bigger than {enteredNumber1}");
    }
else {
    Console.WriteLine("Entered numbers are equal");
    }