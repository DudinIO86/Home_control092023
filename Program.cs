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

string[] VerifyArray(string[] array)//создание нового массива, в который будут помещены отсортированные элементы
{
    int count = NumberElements(array);
 
    string[] SortArray = new string[count]; 

    int index = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3 && array[i]!=" ")
        {
            SortArray[index] = array[i];
            index++;
        }
        
    }
    return SortArray;
}

int NumberElements(string[] array)//определение кол-ва элементов в массиве, у которых число знаков меньше или равно 3
{
int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3 && array[i]!=" ")
        {
            count++;
        }
    }
return count;
}

System.Console.WriteLine("Введите число элементов массива:");
int numberArray=int.Parse(Console.ReadLine());

string[] MyArray=EnterStrMassive(numberArray);
string[] NewArray=VerifyArray(MyArray);

System.Console.WriteLine($"Мой исходный массив: [{string.Join(", ",MyArray)}]");
System.Console.WriteLine($"Элеметы, число символов которых меньше или равно 3: [{string.Join(", ",NewArray)}]");