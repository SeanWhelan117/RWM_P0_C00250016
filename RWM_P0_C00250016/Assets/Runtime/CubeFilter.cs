using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFilter
{
    public static int[] cubes(int[] xs)
    {
        int[] result = new int[xs.Length];
        for (int i = 0; i < xs.Length; i++)
        {
            int firstVal = xs[0];
            result[i] = xs[i];
            if (xs[i] < firstVal)
            {
                result[i] = --xs[i];
                Debug.Log(result[i]);
            }
        }
        return result;
    }
}


