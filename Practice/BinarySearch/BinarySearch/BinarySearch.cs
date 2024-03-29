﻿using System;

namespace BinarySearch;

/// <summary>
/// Двоичный поиск в отсортированном массиве.
/// </summary>
public static class BinarySearch
{
    /// <summary>
    /// Искать число <see cref="x"/> массиве целочисленных чисел.
    /// </summary>
    /// <param name="array">Массив целочисленных чисел.</param>
    /// <param name="x">Искомый элемент.</param>
    /// <returns>Индекс <see cref="x"/> в массиве. Иначе <c>-1</c>, если элемент не найден.</returns>
    public static int Search(int[] array, int x)
    {
        // Здесь нужно реализовать поиск.
        
        int leftIndex = 0;
        int rightIndex = array.Length - 1;

        while (true)
        {
            int middleIndex = (rightIndex + leftIndex) / 2;

            if (leftIndex > rightIndex)
                break;

            if (x == array[middleIndex])
                return middleIndex;

            if (x > array[middleIndex])
                leftIndex = middleIndex + 1;

            if (x < array[middleIndex])
                rightIndex = middleIndex -1;

        }

        return -1;




    }
}