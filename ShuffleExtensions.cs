using System;
using System.Collections.Generic;

namespace CalmCatExtensions
{
    namespace Shuffle
    {
        /// <summary>
        /// Adds an extension method to Shuffle groups of objects with the Fisher-Yates shuffle
        /// </summary>
        public static class ShuffleExtensions
        {
            /// <summary>
            /// Shuffles the contents of the list
            /// </summary>
            /// <param name="random">The Random instance to use for shuffling</param>
            public static void Shuffle<T>(this List<T> list, Random random)
            {
                int count = list.Count;
                for (int i = 0; i < count; i++)
                {
                    int randomNumber = random.Next(i, count);

                    var temp = list[i];

                    list[i] = list[randomNumber];
                    list[randomNumber] = temp;
                }
            }

            /// <summary>
            /// Adds an extension method to Shuffle groups of objects with the Fisher-Yates shuffle
            /// Creates a new instance of Random to shuffle with. You can also pass an instance of random.
            /// </summary>
            public static void Shuffle<T>(this List<T> list)
            {
                Random random = new Random();
                list.Shuffle(random);
            }

            /// <summary>
            /// Adds an extension method to Shuffle groups of objects with the Fisher-Yates shuffle
            /// </summary>
            /// <param name="random">The instance of random to shuffle with</param>
            public static void Shuffle<T>(this T[] array, Random random)
            {
                int count = array.Length - 1;
                for (int i = 0; i < count; i++)
                {
                    int randomNumber = random.Next(i, count);

                    var temp = array[i];

                    array[i] = array[randomNumber];
                    array[randomNumber] = temp;

                }
            }

            /// <summary>
            /// Adds an extension method to Shuffle groups of objects with the Fisher-Yates shuffle
            /// Creates a new instance of Random to shuffle with. You can also pass an instance of random.
            /// </summary>
            public static void Shuffle<T>(this T[] array)
            {
                Random random = new Random();
                array.Shuffle(random);
            }
        }   
    }
}
