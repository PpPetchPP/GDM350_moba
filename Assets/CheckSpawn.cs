using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckSpawn : MonoBehaviour
{
    int die_enermy = 0;
    SpawnEvent spawnEvent = new SpawnEvent();
    private void Start()
    {
        EventManager.AddCheckSpawnInvoker(this);
    }
    private void Update()
    {
        if (die_enermy >= 10 && die_enermy % 10 == 0) 
        {
            EventSpawn();
            die_enermy++;
        }
    }
    public void AddSpawnEvent(UnityAction listener)
    {
        spawnEvent.AddListener(listener);
    }

    public void EventSpawn()
    {
        spawnEvent.Invoke();
    }
    public void count_die_enermy() 
    {
        die_enermy++;
    }
}
