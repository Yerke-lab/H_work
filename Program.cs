
string[] Arr1;
Console.WriteLine("Введите массив строк через пробел");
string array = Console.ReadLine();
Arr1 = array.Split(' ');
int maxLength = 3;
string[] ArrResult(string[] array)
{
int length = array.Length;
string[] result = new string[length];
int count = 0;
for (int i = 0; i < length; i++)
{
    if (array[i].Length <= maxLength)
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
			/* Console.WriteLine("Source array:");
			PrintArray(array); */
			string[] shortArray = ArrResult(array);
			Console.Write("-> ");
			PrintArray(shortArray);
			Console.WriteLine();
		}
		
		PrintTask(Arr1);


