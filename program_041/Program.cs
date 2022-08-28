// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] GettingNumbers(){
    int numberM = new Random().Next(3, 11);
    System.Console.WriteLine($"Вам сейчас надо будет ввести данное количество чисел - {numberM}");
    int[] array = new int[numberM];
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"Введите {i+1} число: ");
        int input = int.Parse(System.Console.ReadLine()!);
        array[i] = input;
    }
    return array;
}

int SearchForPositiveNumbers(int[] array){
    int positiveNumber = 0;
    foreach (int i in array)
    {
        if (i>0) positiveNumber+=1;
    }
    return positiveNumber;
}

int[] newArray = GettingNumbers();
int positive = SearchForPositiveNumbers(newArray);

System.Console.WriteLine($"{String.Join(',', newArray)} -> {positive}");
