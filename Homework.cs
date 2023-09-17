using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_module3_Homework
{
    internal class Homework
    {
        public int[] example1()
        {
            int n = 0;
            Console.WriteLine("Введите размер массива");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("!!!Введите целое число!!!");
            }
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Введите число в  массив");
                while (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.WriteLine("!!!Введите целое число!!!");
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            return arr;
        }
        public int example2(int[] arr)
        {
            int maxValue = arr.Max();
            return Array.IndexOf(arr, maxValue);
        }
        public int example3(int[] arr)
        {
            int max = arr[0];
            int index = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    if (arr[i] >= max)
                    {
                        max = arr[i];
                        index = i;
                    }
                }
            }
            return index;
        }
        public void example4(ref int[] arr, int i = 0)
        {
            if (arr.Length - 1 < i)
            {
                Console.WriteLine("Индекс не входит в массив");
                return;
            }

            for (int j = i; j < arr.Length - 1; j++)
            {
                arr[j] = arr[j + 1];

            }
            Array.Resize(ref arr, arr.Length - 1);
        }
        public void example5(ref int[] arr, int val)
        {
            if (!arr.Contains(val))
            {
                Console.WriteLine("Такого элемента нет!!!");
                return;
            }
            int valIndex = Array.IndexOf(arr, val);

            for (int i = valIndex; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            Array.Resize(ref arr, arr.Length - 1);
        }
        public void example6(ref int[] arr, int i, int val)
        {

            Array.Resize(ref arr, arr.Length + 1);

            if (i < 0 || i >= arr.Length)
            {
                Console.WriteLine("Вы вышли за пределы массива");
                return;
            }


            for (int j = arr.Length - 1; j > i; j--)
            {
                arr[j] = arr[j - 1];
            }


            arr[i] = val;
        }
        public void example7(ref int[] arr)
        {
            List<int> result = new List<int>();
            int i = 0;

            while (i < arr.Length)
            {
                int temp = arr[i];
                int count = 1;

                // Подсчитываем количество элементов temp в массиве
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (temp == arr[j])
                    {
                        count++;
                    }
                }

                // Если элемент встречается ровно дважды, не добавляем его в результат
                if (count != 2)
                {
                    result.Add(temp);
                }

                // Пропускаем все встречающиеся дважды элементы
                while (i < arr.Length && arr[i] == temp)
                {
                    i++;
                }
            }

            // Преобразуем результат обратно в массив
            arr = result.ToArray();
        }
        public string example8(ref string str)
        {
            string[] words = str.Split(' ');

            List<string> filteredWords = new List<string>();

            foreach (string word in words)
            {

                if (!word.Contains('a'))
                {
                    filteredWords.Add(word);
                }
            }
            string result = string.Join(" ", filteredWords);

            return result;
        }
        public void example9()
        {
            int[] A = new int[5];
            int[,] B = new int[3, 4];
            Console.WriteLine("Заполните массив А: ");
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            int rows = B.GetLength(0);
            int cols = B.GetLength(1);
            Random rnd = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    B[i, j] = rnd.Next(1, 100);
                }
            }
            int max = A[0];
            int min = A[0];
            int sum = 0;
            long proiz = 1;
            int sum4et = 0;
            Console.WriteLine("Массив А: ");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
                if (A[i] > max)
                {
                    max = A[i];
                }
                if (A[i] < min)
                {
                    min = A[i];
                }
                sum += A[i];
                proiz *= A[i];
                if (A[i] % 2 == 0)
                {
                    sum4et += A[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("MAX A: " + max);
            Console.WriteLine("MIN A: " + min);
            Console.WriteLine("SUM A: " + sum);
            Console.WriteLine("Сумма Произведение A: " + proiz);
            Console.WriteLine("Сумма четных A: " + sum4et);
            max = A[0];
            min = B[0, 0];
            sum = 0;
            proiz = 1;
            int sumne4et = 0;
            Console.WriteLine("Массив В: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(B[i, j] + " ");
                    if (B[i, j] > max)
                    {
                        max = B[i, j];
                    }
                    if (B[i, j] < min)
                    {
                        min = B[i, j];
                    }
                    sum += B[i, j];
                    proiz *= B[i, j];
                    if (j % 2 != 0)
                    {
                        sumne4et += B[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("MAX B: " + max);
            Console.WriteLine("MIN B: " + min);
            Console.WriteLine("SUM B: " + sum);
            Console.WriteLine("Сумма Произведение B: " + proiz);
            Console.WriteLine("Сумма не четных столбцов B: " + sumne4et);
        }
        public void example10()
        {
            Random rand = new Random();
            int[,] arr = new int[5, 5];
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arr[i, j] = rand.Next(-100, 100);
                }
            }

            int min = arr[0, 0];
            int max = arr[0, 0];
            int[] minIndex = { 0, 0 };
            int[] maxIndex = { 0, 0 };

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(arr[i, j] + " ");
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        maxIndex[0] = i;
                        maxIndex[1] = j;
                    }
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        minIndex[0] = i;
                        minIndex[1] = j;
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Minimum: " + min);
            Console.WriteLine("Maximum: " + max);

            int sum = 0;
            int startRow = Math.Min(minIndex[0], maxIndex[0]);
            int endRow = Math.Max(minIndex[0], maxIndex[0]);
            int startCol = Math.Min(minIndex[1], maxIndex[1]);
            int endCol = Math.Max(minIndex[1], maxIndex[1]);

            for (int i = startRow; i <= endRow; i++)
            {
                for (int j = startCol; j <= endCol; j++)
                {
                    sum += arr[i, j];
                }
            }

            Console.WriteLine("Сумма элементов между минимальным и максимальным: " + sum);
        }

        public void example11(ref string str)
        {
            List<Char> arr = new List<Char>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != '/' && str[i] != '\\')
                {
                    arr.Add(str[i]);
                }

            }
            str = new string(arr.ToArray());
        }
        public string example12(ref string str)
        {
            char[] charArray = str.ToCharArray();

            for (int i = 0; i < charArray.Length - 1; i++)
            {
                if (charArray[i] == charArray[i + 1])
                {
                    charArray[i] = '1';
                    charArray[i + 1] = '1';
                }
            }
            str = new string(charArray);
            return str;
        }

        public int example13( string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {

                if(str[i] == '1' || str[i] == '2' ||str[i] == '3' || str[i] == '4'
                    || str[i] == '5' || str[i] == '6' || str[i] == '7'
                    || str[i] == '8' || str[i] == '9' || str[i] == '0')
                {
                    count++;
                }
            }
            return count;
        }

        public bool example14(string str)
        {
           string[] words  = str.Split(' ');
            foreach (string word in words)
            {
                if(word == "one")
                {
                    return true;
                }
            }
            return false;
        }

        public bool example15(string str)
        {
            foreach (char ch in str)
            {
                if (!char.IsLetterOrDigit(ch))
                {
                    return true;
                }
            }
            return false;
        }
        public char example16(string str)
        {
            int count = 0;
            char letter ='1';
            string[] words = str.Split(' ');
            foreach (string word in words)
            {
                if (letter == word[0])
                {
                    count++;
                }
                letter = word[0];
                
            }
            return letter;
        }
        
        public int example17(string str)
        {
            //Snickers
            string[] words = str.Split(' ');
            int sum = 0;
            foreach (string word in words)
            {
                if(word != " ")
                {
                    if (int.TryParse(word, out int number))
                    {
                        int lastDigit = number % 10;
                        if (lastDigit == 3 || lastDigit == 4)
                        {
                            sum += number;
                        }
                    }
                }
            }
            return sum;
        }

    }
}
