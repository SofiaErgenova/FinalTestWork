/* Программа, которая из имеющегося массива строк формирует
массив из строк, длина которых меньше либо равна трем символам.  */

/* Пример массива: string [] symbols = {"hello", "2", "world",":-)"}; */

    Console.WriteLine("Введите количество элементов массива: ");
    int count = Convert.ToInt32(Console.ReadLine());

    string [] symbols = new string [count];

    void CreateArray (string[] array)
        {
            for(int i = 0; i < count; i++)
                {
                    Console.WriteLine($"Введите элемент массива c индексом {i}: ");
                    array[i] = Convert.ToString(Console.ReadLine());
                }
        }

CreateArray(symbols);

void PrintArray(string [] array)
{
    Console.Write($"[");
    for(int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"\"{array[i]}\",");
    }
    Console.Write($"\"{array[array.Length-1]}\"]");
}

 PrintArray(symbols);
 
 int length = 0;
 for(int i = 0; i < symbols.Length; i++)
    {
        string test = symbols[i];
        if(test.Length <= 3)
            {
               length = length + 1;
            }   
    }

string [] threeSymbols = new string [length];
 for(int j = 0, i = 0; j < length; i++)
    {
         if(symbols[i].Length <= 3)
            {
                 threeSymbols[j] = symbols[i];
                 j++;
            } 
        
    }
PrintArray(threeSymbols);
