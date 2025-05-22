using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorna__10
{
    internal class WorkingWithArray
    {
        private int[,] intArray;
        private int?[] arraySummElementRowIntArray;
        private int[,] saddlePoints;

        public WorkingWithArray()
        {
            bool isCorrectValueRowsAndColumnsArray = false;
            while (!isCorrectValueRowsAndColumnsArray)
            {
                try
                {
                    Console.Write("Введть кількість рядків матриці: ");
                    int rows = int.Parse(Console.ReadLine());
                    Console.Write("Введть кількість стовців матриці: ");
                    int cols = int.Parse(Console.ReadLine());
                    intArray = new int[rows, cols];
                    arraySummElementRowIntArray = new int?[rows];
                    saddlePoints = new int[Math.Min(rows, cols),2];
                    isCorrectValueRowsAndColumnsArray = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введені дані не є числом. Спробуйте ще раз.");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Ви не ввели жодних даних. Спробуйте ще раз.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Введене число виходить за межі допустимого діапазону типу int. Спробуйте ще раз.");
                }
            }
            inputRandomDataInArray();
            inputStartValueArraySummElementRowIntArray();
            inputStartValueArraySaddlePoints();
        }

        private void inputRandomDataInArray()
        {
            Random random = new Random();
            for (int i = 0; i < intArray.GetLength(0); i++) 
            { 
                for(int j=0;j<intArray.GetLength(1); j++)
                {
                    intArray[i, j] = random.Next(-50, 51);
                }
            }
        }

        private void inputStartValueArraySummElementRowIntArray()
        {
            for(int i = 0; i < intArray.GetLength(0); i++)
            {
                arraySummElementRowIntArray[i] = 0;
            }
        }

        private void inputStartValueArraySaddlePoints()
        {
            for(int i = 0; i < saddlePoints.GetLength(0); i++)
            {
                for(int j=0;j< saddlePoints.GetLength(1); j++)
                {
                    saddlePoints[i, j] = -1;
                }
            }
        }

        public void printIntMatrix()
        {
            Console.WriteLine("Матриця: ");
            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    Console.Write(intArray[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }

        private bool[] isNegativeElementInRow()
        {
            bool[] isNegativeElementsInRow=new bool[intArray.GetLength(0)];
            for(int i = 0; i < intArray.GetLength(0); i++)
            {
                for(int j=0;j< intArray.GetLength(1); j++)
                {
                    if (intArray[i, j] < 0)
                    {
                        isNegativeElementsInRow[i] = true;
                        break;
                    }
                }
            }

            return isNegativeElementsInRow;
        }
        public void summRowsWhereIsNegativeElement()
        {
            for(int i=0;i< intArray.GetLength(0); i++)
            {
                if (isNegativeElementInRow()[i])
                {
                    for (int j = 0; j < intArray.GetLength(1); j++)
                    {
                        arraySummElementRowIntArray[i] += intArray[i, j];
                    }
                }
                else
                {
                    arraySummElementRowIntArray[i] = null;
                }
            }
            printArraySummElementRowIntArray();
        }

        private void printArraySummElementRowIntArray()
        {
            Console.WriteLine("Масив з сумами елементів рядків матриці де присутні від'ємні числа: ");
            for(int i=0;i< arraySummElementRowIntArray.GetLength(0); i++)
            {
                if (arraySummElementRowIntArray[i] == null)
                {
                    Console.WriteLine(i+1 +") Рядок не має від'ємних елементів;");
                }
                else
                {
                    Console.WriteLine(i + 1 + ") Сума рядка: "+arraySummElementRowIntArray[i]);
                }
            }
        }

        public void searchSaddlePoint()
        {
            int[,] minimumPointsInAllRows = searchMinElementInRows();
            int[,] maximumPointInAllColumns=searchMaxElementInColumns();
            int indexAddSiddlePoint = 0;
            
            for(int i=0;i<minimumPointsInAllRows.GetLength(0); i++)
            {
                for(int j=0;j<maximumPointInAllColumns.GetLength(0); j++)
                {
                    if (minimumPointsInAllRows[i,0]==maximumPointInAllColumns[j,0] && minimumPointsInAllRows[i, 1] == maximumPointInAllColumns[j, 1])
                    {
                        saddlePoints[indexAddSiddlePoint, 0] = minimumPointsInAllRows[i, 0];
                        saddlePoints[indexAddSiddlePoint, 1] = minimumPointsInAllRows[i, 1];
                        indexAddSiddlePoint++;
                    }
                }
            }
            printSiddlePoint(indexAddSiddlePoint);
        }

        private void printSiddlePoint(int countPoints)
        {
            if(countPoints == 0)
            {
                Console.WriteLine("Сідлових точок не знайдено!!!");
            }
            else
            {
                Console.Write("Координати сідлових точок: ");
                for (int i = 0; i < saddlePoints.GetLength(0); i++)
                {
                    for(int j = 0;j < saddlePoints.GetLength(1); j++)
                    {
                        if (saddlePoints[i, j] == -1)
                        {
                            continue;
                        }
                        else
                        {
                            Console.Write(saddlePoints[i, j] + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }

        private int[,] searchMinElementInRows()
        {
            int[,] cordinatesOfTheMinimumPointInRows=new int[intArray.GetLength(0),2];
            for(int i = 0; i < intArray.GetLength(0); i++)
            {
                int tmpMinElement = intArray[i, 0];
                int index = 0;
                for(int j=0;j<intArray.GetLength(1); j++)
                {
                    if (intArray[i, j] < tmpMinElement)
                    {
                        tmpMinElement = intArray[i, j];
                        index = j;
                    }
                }
                cordinatesOfTheMinimumPointInRows[i, 0] = i;
                cordinatesOfTheMinimumPointInRows[i, 1] = index;
            }

            return cordinatesOfTheMinimumPointInRows;
        }

        private int[,] searchMaxElementInColumns()
        {
            int[,] cordinatesOfTheMaximumPointInColumns = new int[intArray.GetLength(1), 2];
            for(int j = 0; j < intArray.GetLength(1); j++)
            {
                int tmpMaxElement = intArray[0, j];
                int index = 0;
                for(int i=0;i<intArray.GetLength(0); i++)
                {
                    if (tmpMaxElement < intArray[i, j])
                    {
                        tmpMaxElement = intArray[i, j];
                        index = i;
                    }
                }
                cordinatesOfTheMaximumPointInColumns[j, 0] = index;
                cordinatesOfTheMaximumPointInColumns[j, 1] = j;
            }

            return cordinatesOfTheMaximumPointInColumns;
        }

        private int summOddNumbered()
        {
            int summOddNumbered = 0;

            for(int i = 0; i < intArray.GetLength(0); i++)
            {
                for(int j = 0;j < intArray.GetLength(1); j++)
                {
                    if(!((i+j)%2 == 0))
                    {
                        summOddNumbered += intArray[i, j];
                    }
                }
            }
            return summOddNumbered;
        }
    }
}
