// Пользователь вводит с клавиатуры М чисел. Посчитайте сколько чисел больше 0 ввёл пользователь.

int [] GenerateArray () {
Console.WriteLine("Введите число через ,");
string input = Console.ReadLine();
string[] arraynumbers = input.Split(",");
int[] numbers = new int[arraynumbers.Length];
for (int i = 0; i < arraynumbers.Length; i++)
{
    numbers[i] = Convert.ToInt32(arraynumbers[i]);
}
return numbers;
}

void Printarray(int[] array) {
foreach (int number in array) // Перебирает каждый элемент объекта в нашем массиве
{
    
    Console.Write(number + " "); 
}
}

int Count(int[]  numbers) {
int resalt = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] > 0) resalt++;
}
return resalt;

}

int[] array = GenerateArray();
Printarray(array);
int res = Count(array);
Console.WriteLine("Количество чисел больше 0 - " + res);