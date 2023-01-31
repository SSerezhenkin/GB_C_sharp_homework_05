
void PrintArr(int[] arr)
{
    foreach (int item in arr)
    {
        System.Console.Write(item + " ");
    }
    System.Console.WriteLine();
}

int[] RandomArr(int len, int min, int max)
    {
        int[] arr = new int[len];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(min, max);
        }
        return arr;
    }

void Task01()
{
    bool IsEven(int num)
    {
        if (num % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    int HowMuchEvens(int[] arr)
    {
        int result = 0;
        foreach (int i in arr)
        {
            if (IsEven(i))
            {
                result++;
            } 
        }
        return result;
    }

    int[] arr = RandomArr(10, 100, 1000);
    PrintArr(arr);
    System.Console.WriteLine("Чётных чисел в массиве: " + HowMuchEvens(arr));
}

void Task02()
{
    int SumOfOdd(int[] arr)
    {
        int result = 0;
        for (int i = 1; i < arr.Length; i+=2)
        {
            result += arr[i];
        }
        return result;
    }

    int[] arr = RandomArr(10, -100, 100);
    PrintArr(arr);
    System.Console.WriteLine("Сумма чисел на нечётной позиции: " + SumOfOdd(arr));

}

void Task03()
{
    int FindMax(int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (max > arr[i]) continue;
            else max = arr[i];
        }
        return max;
    }
    int FindMin(int[] arr)
    {
        int min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (min < arr[i]) continue;
            else min = arr[i];
        }
        return min;
    }
    int[] arr = RandomArr(10, -10, 1000);
    PrintArr(arr);
    System.Console.WriteLine("Разница между максимальным и минимальным числами массива: " + (FindMax(arr) - FindMin(arr)));
}

System.Console.WriteLine("Введите номер задачи, где: \n 1 - количество четных чисел в массиве \n 2 - сумма элементов на нечётных позициях \n 3 - разница между максимальным и минимальным в массиве");
int task = Convert.ToInt32(Console.ReadLine());
switch(task)
{
    case 1:
        Task01();
        break;
    case 2:
        Task02();
        break;
    case 3:
        Task03();
        break;
    default:
        System.Console.WriteLine("Такой задачи нет");
        break;
}