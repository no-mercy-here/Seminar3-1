// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Enter a number");
string enteredNumber = Console.ReadLine();
int N = Convert.ToInt32(enteredNumber);
int evenNumber = 2;

if (N <= 1) {
    Console.WriteLine("There're no even numbers in the range from 1 to the entered number.");
}
while (evenNumber <= N) {
    Console.WriteLine(evenNumber);
    evenNumber = evenNumber + 2;
    }