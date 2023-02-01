/* Задача 41: Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
вводим через один Enter (разбиваем через Split()) */
int[] GetNumbers(int countNum){
    
    int[] numbers = new int[countNum];
    for (int i = 0; i < countNum; i++)
    {
        Console.WriteLine($"Введите число №{i+1} ");
        if(int.TryParse(Console.ReadLine(),out numbers[i]));
        else Console.WriteLine("введите число");
        
    }
    return numbers;
}
int CountPlNum(int[] numbers){
    int count = 0;
    
    for (int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i]>0) count++;
        
    }
    return count;
    
}

int[] numbers = GetNumbers(5);
Console.WriteLine("[{0}]",string.Join(" ",numbers));
int result = CountPlNum(numbers);
Console.WriteLine($"кол-во положительных чисел: {result}");
