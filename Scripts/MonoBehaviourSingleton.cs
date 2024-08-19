using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoBehaviourSingleton<T> : MonoBehaviour where T : Component
{
    private static T _instance;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<T>();

                if (_instance == null)
                {
                    GameObject newObj = new GameObject("Auto-generated " + typeof(T));
                    _instance = newObj.AddComponent<T>();
                }
                else
                {
                    DontDestroyOnLoad(_instance);
                }
            }

            return _instance;
        }
    }
}