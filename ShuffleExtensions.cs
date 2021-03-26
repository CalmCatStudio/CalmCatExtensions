using System;
using System.Collections.Generic;

namespace CalmCatExtensions
{
    /// <summary>
    /// Adds an extension method to Shuffles groups of objects with the Fisher-Yates shuffle
    /// </summary>
    public static class ShuffleExtensions
    {
        /// <summary>
        /// Shuffles a list of objects
        /// </summary>
        /// <param name="list">The list to shuffle</param>
        /// <param name="random">The Random instance to use for shuffling</param>
        /// <returns></returns>
        public static List<T> Shuffle<T>(this List<T> list, Random random)
        {
            int count = list.Count;
            for (int i = 0; i < count; i++)
            {
                int randomNumber = random.Next(i, count);

                var temp = list[i];

                list[i] = list[randomNumber];
                list[randomNumber] = temp;
            }
            return list;
        }

        /// <summary>
        /// Creates a new Random, and shuffles the deck with it
        /// </summary>
        /// <param name="list">The list to shuffle</param>
        /// <returns></returns>
        public static List<T> Shuffle<T>(this List<T> list)
        {
            Random random = new Random();
            return list.Shuffle(random);
        }

        public static T[] Shuffle<T>(this T[] array, Random random)
        {
            int count = array.Length - 1;
            for (int i = 0; i < count; i++)
            {
                int randomNumber = random.Next(i, count);

                var temp = array[i];

                array[i] = array[randomNumber];
                array[randomNumber] = temp;

            }
            return array;
        }

        public static T[] Shuffle<T>(this T[] array)
        {
            Random random = new Random();
            return array.Shuffle(random);
        }
    }
}
