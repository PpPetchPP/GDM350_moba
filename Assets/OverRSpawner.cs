using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverRSpawner : Spawner
{
    public override void Generate()
    {
        random.x = Random.Range(-20f, -40f);
        random.z = Random.Range(-50f, 50f);

        Instantiate(ennermy_oj, random, this.transform.rotation);
        amount++;
    }
}
