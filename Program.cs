// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] EnterStrMassive(int number)//функция ввода исходного массива
{
    string[] StrArray=new string[number];

    for(int i=0;i<StrArray.Length;i++)
    {
        System.Console.WriteLine($"Введите элемент массива №{i+1}: ");
        StrArray[i]=Console.ReadLine();
    }
return StrArray;
}

System.Console.WriteLine("Введите число элементов массива:");
int numberArray=int.Parse(Console.ReadLine());

string[] MyArray=EnterStrMassive(numberArray);
System.Console.WriteLine($"Мой исходный массив: [{string.Join(", ",MyArray)}]");
