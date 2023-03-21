/* 
Задача: 
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

/*
Формируем стартовый массив
Будет состоять из случайного (до 10) количества элементов-строк, 
каждая строка состоит из случайного набора символов, дина выбирается случано, до 7 символов в строке
*/

string RandomString()  //метод создания случайной строки
{
Random myRand = new Random();  
string returnedStr = "";
for(int i = 0; i < new Random().Next(1, 7);i++)  // длина набора от 1 до 7 символов, длина выбирается случайно
{
    char myChar =(char)myRand.Next(33, 125); // берем по таблице кодировки символов буквы и знаки
    returnedStr += myChar ;
}
return returnedStr;
}

string [] RandomString2()  // метод создания массива случайных строк, количество элементов массива от 5 до 10, выбирается случайно 
{
    int len = new Random().Next(5, 10);
    string [] returnedArray = new string[len];
    for (int i = 0; i< len; i++)
{
returnedArray[i] = RandomString();
}
return returnedArray;
}



void ShowArray (string [] array)   //  метод вывода массива 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
    Console.WriteLine();
}


/*
string [] CreateNewStrArray (int n)
{
    string [] array = new string[n];
    for (int i = 0; i < n; i++)
    {
        for (int j =0; j < new Random().Next(1, 6); j++) // массив из любых чисел от -100 до 100
        {
            array[i] = array[i]+new Random().Next(0x0410, 0x44F); // массив из любых чисел от -100 до 100
        }

    }
    return array; 

}

void ShowArray (string [] array)   //  метод вывода массива 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
*/
string [] newArray = RandomString2();
ShowArray(newArray);