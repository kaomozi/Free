using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class AcSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
    static T m_instance = null;
    public static T Instance
    {
        get
        {
            if (m_instance == null)
            {
                Type t = typeof(T);
                m_instance = (T)FindObjectOfType(t);
                if (m_instance == null)
                {
                    AcDebug.LogError(t + " をアタッチしているGameObjectはありません");
                }
            }

            return m_instance;
        }
    }

}

