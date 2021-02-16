using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverRTORNADO : BasicSkill
{
    public override void Update()
    {
        LifeTime();
        move();
    }
}
