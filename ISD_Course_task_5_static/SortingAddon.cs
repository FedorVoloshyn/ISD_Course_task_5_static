using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_5_static
{
    public static class SortingAddon
    {
        public static void SortArray(this int[] mas)
        {
            for (int i = 0; i < mas.Length - 1; i++)
            {
                for (int j = 0; j < mas.Length - i - 1; j++)
                {
                    if (mas[j] > mas[j + 1])
                    {
                        int b = mas[j];
                        mas[j] = mas[j + 1];
                        mas[j + 1] = b;
                    }
                }
            }
        }

        public static void SortArray(this int[] mas, bool direction)
        {
            if (direction)
            {
                for (int i = 0; i < mas.Length - 1; i++)
                {
                    for (int j = 0; j < mas.Length - i - 1; j++)
                    {
                        if (mas[j] > mas[j + 1])
                        {
                            int b = mas[j];
                            mas[j] = mas[j + 1];
                            mas[j + 1] = b;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < mas.Length - 1; i++)
                {
                    for (int j = 0; j < mas.Length - i - 1; j++)
                    {
                        if (mas[j] < mas[j + 1])
                        {
                            int b = mas[j];
                            mas[j] = mas[j + 1];
                            mas[j + 1] = b;
                        }
                    }
                }
            }
        }
    }
}
