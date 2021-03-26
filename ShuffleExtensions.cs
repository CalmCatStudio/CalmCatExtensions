using System;
using System.Collections.Generic;

namespace CalmCatExtensions
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
        /// Creates a new instance of Random, and shuffles the contents of the list with it
        /// </summary>
        public static void Shuffle<T>(this List<T> list)
        {
            Random random = new Random();
            list.Shuffle(random);
        }

        /// <summary>
        /// Shuffles the contents of the array
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
        /// Creates a new instance of Random and shuffles the contents of the array with it.
        /// </summary>
        public static void Shuffle<T>(this T[] array)
        {
            Random random = new Random();
            array.Shuffle(random);
        }
    }
}
