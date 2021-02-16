using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverRMETEOR : BasicSkill
{
    public override void Update()
    {
        LifeTime();
        delaytime -= Time.deltaTime;
        if (delaytime <= 0)
        {
            move();          
        }
    }
}
