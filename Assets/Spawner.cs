using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject ennermy_oj;
    public GameObject ennermy_oj2;
    protected float max_speed = 0.75f;
    protected float speed = 5;
    protected int max_amount = 5;
    protected int amount = 0;

    protected Vector3 random;

    protected void Start()
    {
        Start_invoke();
        EventManager.AddCheckSpawnListener(SpawnEvent);
    }

    protected void Update()
    {       
        if (amount == max_amount) 
        {
            Cancel_invoke();
        }

    }
    protected void Start_invoke() 
    {
        if (!IsInvoking("Generate"))
        {
            InvokeRepeating("Generate", 5, speed);
        }
    }
    protected void Cancel_invoke() 
    {
        CancelInvoke("Generate");
        amount = 0;
        Upgrade_invoke();
    }
    protected void Upgrade_invoke() 
    {
        if (speed > max_speed) 
        {
            speed = speed / 1.25f;
        }
        max_amount++;
        Start_invoke();
    }

    public virtual void Generate() 
    {
        random.x = Random.Range(20f, 40f);
        random.z = Random.Range(-50f, 50f);

        Instantiate(ennermy_oj, random, this.transform.rotation);
        amount++;
    }

    public void SpawnEvent() 
    {
        random.x = Random.Range(20f, 40f);
        random.z = Random.Range(-50f, 50f);

        Instantiate(ennermy_oj2, random, this.transform.rotation);
    }
}
