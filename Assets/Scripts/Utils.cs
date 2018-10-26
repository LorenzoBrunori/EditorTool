using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Utils
{
    private static readonly Utils instance = new Utils();

    private Utils()
    {

    }

    public static Utils Instance
    {
        get
        {
            return instance;
        }
    }

    public int Random(int Min, int Max)
    {
        return UnityEngine.Random.Range(Min, Max);
    }
}
