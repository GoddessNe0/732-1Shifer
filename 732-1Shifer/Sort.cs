using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _732_1Shifer
{
    public class Sort
    {
        public string MakeSort(string input)
        {
            string[] numbers = input.Split(' ');

            foreach (string number in numbers)
            {
                if (int.TryParse(number, out int n))
                {
                    if (n < 2 || n > 65536)
                    {
                        return $"Ошибка: Введите число от 2 до 65536.";
                    }

                    string result = GenerateSieve(n);

                    return result;
                }
                else
                {
                    return $"Ошибка: {number} не является целым числом.";
                }
            }

            return ""; 
        }

        string GenerateSieve(int n)
        {
            int nNew = (n - 2) / 2;
            bool[] marked = new bool[nNew + 1];

            for (int i = 1; i <= nNew; i++)
            {
                int j = i;
                while ((i + j + 2 * i * j) <= nNew)
                {
                    marked[i + j + 2 * i * j] = true;
                    j++;
                }
            }

            string result = $"Простые числа до {n}: ";

            if (n > 2)
                result += "2 ";

            for (int i = 1; i <= nNew; i++)
            {
                if (marked[i] == false)
                    result += (2 * i + 1) + " ";
            }

            return result;
        }

    }
}
