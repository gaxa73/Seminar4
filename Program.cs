Console.WriteLine("Hello, World!");
Console.WriteLine("Методы!");
/*Console.WriteLine("Задача 1!");
//Принимаем число (А)
//Выдаем сумму чисел от 1 до (А)

Console.WriteLine("Введите число! ");//Код для методов.
int limit = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма чисел от 1 до {limit} равна {GetSum(limit)}");
//Код в методе можно повторять
//только меняем переменные
Console.WriteLine("Введите число! ");//Код для методов.
int Num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма чисел от 1 до {Num} равна {GetSum(Num)}");


//----------Методы-------------;
int GetSum(int A){
    int sum = 0;
    for(int i = 1; i <= A; i++){
        sum += i;//sum = sum + i
    }
    return sum; //Возвращение
}*/

//Задача 2
// Принимаем на вход число N и выдаёт 
//произведение чисел от 1 до N.

/*Console.WriteLine("Задача 2!");
Console.WriteLine("Введите число! ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Произведение чисел от 1 до {N} равно {GetMultiply(N)}");


//-------Метод-------
int GetMultiply(int N){
    int m = 1;
    for(int i = 1; i <= N; i++){
        m = m * i;
    }
    return m; //Возвращение
}*/

//Задача 3
//Принимает на вход число и 
//выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5
/*Console.WriteLine("Задача 3!");
Console.WriteLine("Введите число! ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Количество цифр {A} Равно {num(A)}");
string M = A.ToString();//для строкового метода
Console.WriteLine($"Количество цифр {M} Равно {num2(M)}");//для строкового метода

//--------Метод математический-----
int num (int n){
    int a = 0;
    if (n == 0) return 1;
    while (n > 0){
        a++;
        n = n / 10;
    }
    return a;
}

//-------строковый-----
int num2 (string n){
    int a = n.Length;
    return a;
}*/

//Массив из 8 элементов, заполненный нулями
// и единицами в случайном порядке.
//1,0,1,1,0,1,0,0
/*int[] GetArray(int size){
    int[] myArray = new int[size];
    for(int i = 0; i < size; i++){
        myArray[i] = new Random().Next(2);
    }
    return myArray;
}

int[] myArray = GetArray(8);
Console.WriteLine($"[{String.Join(',', myArray)}]");*/

//Задача 25: 
//Напишите цикл, который принимает на вход
//два числа (A и B) и возводит число A 
//в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
/*Console.WriteLine("Домашнее задание! ");
int number1(int numberA, int numberB){
  int result = 1;
  for(int i=1; i <= numberB; i++){
    result = result * numberA;
  }
    
    return result;
}

  Console.Write("Введите число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int number2 = number1(numberA, numberB);
  Console.WriteLine("Ответ: " + number2);*/

//Задача 27: 
//принимает на вход число 
//и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
/*Console.WriteLine("Домашнее задание! ");
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

  int SumN(int numberN){
    
    int count = Convert.ToString(numberN).Length;
    int adv = 0;
    int result = 0;

    for (int i = 0; i < count; i++){
      adv = numberN - numberN % 10;
      result = result + (numberN - adv);
      numberN = numberN / 10;
    }
   return result;
  }
int sumN1 = SumN(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumN1);*/


//Задача 29: 
//Напишите программу, которая задаёт массив 
//из 8 элементов и выводит их на экран. (числа берете любые)
Console.WriteLine("Домашнее задание! ");
Console.Write("Массив: ");
int[] GetArray(int size){
    int[] myArray = new int[size];
    for(int i = 0; i < size; i++){
        myArray[i] = new Random().Next(8);
    }
    return myArray;
}

int[] myArray = GetArray(8);
Console.WriteLine($"[{String.Join(',', myArray)}]");
