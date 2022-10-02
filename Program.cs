// Первый способ решения 
string[] Arr1;
Console.WriteLine("Введите массив строк через пробел");
string array = Console.ReadLine();
Arr1 = array.Split(' ');
string[] ArrResult(string[] array)
{
int length = array.Length;
string[] result = new string[length];
int count = 0;
for (int i = 0; i < length; i++)
{
    if (array[i].Length <= 3)
    {
        result[count] = array[i];
        count++;
    }
}
Array.Resize(ref result, count);
return result;
}

void PrintArray(string[] array)
{
if(array.Length == 0)
			{
				Console.WriteLine("Массив пуст");
			}
			else
			{
				Array.ForEach(array, (str) => Console.Write($"{str} "));
				Console.WriteLine();
			}
		}
void PrintTask(string[] array)
		{
			string[] shortArray = ArrResult(array);
			Console.Write("-> ");
			PrintArray(shortArray);
			Console.WriteLine();
		}
PrintTask(Arr1);
 
//Второй способ решения
/*string[] Arr;
            Console.WriteLine("Введите массив строк через пробел");
            string array = Console.ReadLine();
            Arr = array.Split(' ');
            var result = new string[Arr .Length];
            var realSize = 0;
            foreach (var value in Arr )
            {
                if (value.Length <= 3)
                {
                    result[realSize] = value;
                    realSize++;
                }
            }
            Console.Write($"-> {string.Join(Environment.NewLine, result, 0, realSize)} ");
            Console.ReadKey(true);*/