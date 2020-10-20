using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AcDebug 
{
    // Log
    public static void Log(object log)
    {
        Debug.Log(log);
    }

    public static void LogWarning(object log)
    {
        Debug.LogWarning(log);
    }

    public static void LogError(object log)
    {
        Debug.LogError(log);        
    }
}
