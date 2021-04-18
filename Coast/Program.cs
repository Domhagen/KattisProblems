using System;

namespace Coast
{
    class Program
    {
        static int a;
        static int e;

        static void Main(string[] args)
        {
            int[][] coastGrid = new int[5][];



            coastGrid[0] = new int[] { 0, 1, 1, 1, 1, 0 };
            coastGrid[1] = new int[] { 0, 1, 0, 1, 1, 0 };
            coastGrid[2] = new int[] { 1, 1, 1, 0, 0, 0 };
            coastGrid[3] = new int[] { 0, 0, 0, 0, 1, 0 };
            coastGrid[4] = new int[] { 0, 0, 0, 0, 0, 0 };


            int coastLines = 0;
            //coastGrid[a][e] = 1 ;

            calcCoastLines(coastGrid);
            //checkForLakes(coastGrid);
            Console.WriteLine($"number of coast lines are {coastLines}");

            int calcCoastLines(int[][] jaggedArray)
            {
                foreach (int[] array in jaggedArray)
                {
                    foreach (var value in array)
                    {
                        if (value == 1)
                        {
                            try
                            {
                                if (jaggedArray[+1][array[value]] == 1)
                                {
                                    coastLines = coastLines + 0;
                                }
                                else if (jaggedArray[+1][array[value]] == 0)
                                {
                                    coastLines++;
                                }
                            }
                            catch (Exception)
                            {
                                coastLines++;
                            }
                            try
                            {
                                if (coastGrid[-1][value] == 1)
                                {
                                    coastLines = coastLines + 0;
                                }
                                else if (coastGrid[-1][value] == 0)
                                {
                                    coastLines++;
                                }
                            }
                            catch (Exception)
                            {
                                coastLines++;
                            }
                            try
                            {
                                if (array[value+1] == 1)
                                {
                                    coastLines = coastLines + 0;
                                }
                                else if (array[value+1] == 0)
                                {
                                    coastLines++;
                                }
                            }
                            catch (Exception)
                            {
                                coastLines++;
                            }
                            try
                            {
                                if (array[value - 1] == 0)
                                {
                                    coastLines++;
                                }
                                else if (array[value - 1] == 1)
                                {
                                    coastLines = coastLines + 0;
                                }
                            }
                            catch (Exception)
                            {
                                coastLines++;
                            }
                        }
                    }
                }
                return coastLines;
            }
            //int checkForLakes(int[][] jaggedArray)
            //{
            //    foreach (int[] array in jaggedArray)
            //    {
            //        foreach (var value in array)
            //        {
            //            if (value == 0)
            //            {
            //                int lakeLines = 0;
            //                try
            //                {
            //                    if (jaggedArray[a + 1][e] == 1)
            //                    {
            //                        lakeLines++;
            //                    }
            //                    else if (jaggedArray[a + 1][e] == 0)
            //                    {
            //                        lakeLines = lakeLines + 0;
            //                    }
            //                }
            //                catch (Exception)
            //                {
            //                    lakeLines++;
            //                }
            //                try
            //                {
            //                    if (jaggedArray[a - 1][e] == 1)
            //                    {
            //                        lakeLines++;
            //                    }
            //                    else if (jaggedArray[a - 1][e] == 0)
            //                    {
            //                        lakeLines = lakeLines + 0;
            //                    }
            //                }
            //                catch (Exception)
            //                {
            //                    lakeLines++;
            //                }
            //                try
            //                {
            //                    if (jaggedArray[a][e + 1] == 1)
            //                    {
            //                        lakeLines++;
            //                    }
            //                    else if (jaggedArray[a][e + 1] == 0)
            //                    {
            //                        lakeLines = lakeLines + 0;
            //                    }
            //                }
            //                catch (Exception)
            //                {
            //                    lakeLines++;
            //                }
            //                try
            //                {
            //                    if (jaggedArray[a][e - 1] == 1)
            //                    {
            //                        lakeLines++;
            //                    }
            //                    else if (jaggedArray[a][e - 1] == 0)
            //                    {
            //                        lakeLines = lakeLines + 0;
            //                    }
            //                }
            //                catch (Exception)
            //                {
            //                    lakeLines++;
            //                }
            //                if(lakeLines >= 4)
            //                {
            //                    return coastLines = coastLines - 4;
            //                }
            //            }
            //        }
            //    }
            //    return coastLines;
            //}
        }
    }
}
