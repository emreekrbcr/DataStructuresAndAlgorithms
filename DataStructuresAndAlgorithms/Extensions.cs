using System.Collections.Generic;
using DataStructuresAndAlgorithms.Algorithms.SortingAlgorithms;

namespace DataStructuresAndAlgorithms
{
    static class Extensions //String ve diziler için extension metod kullanımı, Genel olanlar buraya
    {
        public static bool IsLower(this string thisString, string comparedString)
        {
            thisString = thisString.ToLower(); //ASCII kodlarına göre her iki string'de küçük harflerden oluşsun ve sorun olmasın diye
            comparedString = comparedString.ToLower();

            int shortStringLength = thisString.Length <= comparedString.Length ? thisString.Length : comparedString.Length; //ternary if yapısı

            for (int i = 0; i < shortStringLength; i++)
            {
                if ((int)thisString[i] < (int)comparedString[i])
                {
                    return true;
                }

                if ((int)thisString[i] > (int)comparedString[i])
                {
                    return false;
                }

                //iki harf eşitse kıyaslamaya sonraki harften devam eder
            }

            return false;
        }

        public static T[] CopyToArray<T>(this IEnumerable<T> thisEnumerable, int length)
        {
            T[] array = new T[length];

            int i = 0;

            foreach (var item in thisEnumerable)
            {
                array[i] = item;
                i++;
            }

            return array;
        }

        public static int[] SortArray(this int[] arrayToBeSorted)
        {
            ISortingAlgorithm sortingAlgorithm = new InsertionSort(); //polymorphism'in güzel bir örneği, yarın bir gün daha iyi bir sıralama algoritması geldiğinde sadece burayı değiştirerek sistemimde kullanabilirim
            int[] newSortedArray = sortingAlgorithm.Sort(arrayToBeSorted);

            return newSortedArray;
        }

        public static string[] SortArray(this string[] arrayToBeSorted)
        {
            ISortingAlgorithm sortingAlgorithm = new InsertionSort(); //polymorphism'in güzel bir örneği, yarın bir gün daha iyi bir sıralama algoritması geldiğinde sadece burayı değiştirerek sistemimde kullanabilirim
            string[] newSortedArray = sortingAlgorithm.Sort(arrayToBeSorted);

            return newSortedArray;
        }
    }
}
