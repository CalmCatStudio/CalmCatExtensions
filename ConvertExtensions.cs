using System.Collections.Generic;

namespace CalmCatExtensions
{
    namespace Convert
    {
        public static class ConvertExtensions
        {
            public static T[,] ConvertArrayTo2DArray<T>(this T[] arrayToConvert, int xSize, int ySize)
            {
                T[,] arrayAs2DArray = new T[xSize, ySize];

                int i = 0;
                for (int y = 0; y < ySize; y++)
                {
                    for (int x = 0; x < xSize; x++)
                    {
                        arrayAs2DArray[x, y] = arrayToConvert[i];
                        i++;
                    }
                }

                return arrayAs2DArray;
            }

            /// <summary>
            /// Untested, I only needed the array version at the moment. It should work though.
            /// </summary>
            public static T[,] ConvertListTo2DArray<T>(this List<T> listToConvert, int xSize, int ySize)
            {
                T[,] listAs2DArray = new T[xSize, ySize];

                int i = 0;
                for (int y = 0; y < ySize; y++)
                {
                    for (int x = 0; x < xSize; x++)
                    {
                        listAs2DArray[x, y] = listToConvert[i];
                        i++;
                    }
                }

                return listAs2DArray;
            }
        }
    }
}
