using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    static CheckSpawn checkSpawnInvoker;
    static UnityAction checkSpawnListener;

    public static void AddCheckSpawnInvoker(CheckSpawn invoker) 
    {
        checkSpawnInvoker = invoker;
        if (checkSpawnListener != null) 
        {
            checkSpawnInvoker.AddSpawnEvent(checkSpawnListener);
        }
    }
    public static void AddCheckSpawnListener(UnityAction listener) 
    {
        checkSpawnListener = listener;
        if (checkSpawnInvoker != null) 
        {
            checkSpawnInvoker.AddSpawnEvent(checkSpawnListener);
        }
    }
}
