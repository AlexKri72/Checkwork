/* Задача:   
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.  

Примеры:  
["hello", "2", "world", ":-)"] -> ["2", ":-)"]  
["1234", "1567", "-2", "computer science"] -> ["-2"]  
["Russia", "Denmark", "Kazan"] -> []    */
Console.Clear();

Console.Write("Сколько слов будем вводить?: ");
int n = int.Parse(Console.ReadLine());
string[] stringInArray = new string[n];
string[] stringOutArray = new string[n];

Console.WriteLine($"Введите любые {n} слов через Enter: ");
for (int i = 0; i < stringInArray.Length; i++) stringInArray[i] = Console.ReadLine();
int count = 0; // эта переменная нужна чтобы выходной массив заполнялся без пробелов
for (int i = 0; i < stringInArray.Length; i++)
{
    if (stringInArray[i].Length <= 3) 
    {
        stringOutArray[count] = stringInArray[i]; // если длина меньше или равна трем, запоминаем элемент в выходной массив
        count++;
    }
}
Console.Write("Результат выборки слов : ");
string str = string.Join(" ", stringOutArray).Trim();
Console.WriteLine($"{str}\n");
