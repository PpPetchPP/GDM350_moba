using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverRSUNIN : BasicSkill
{
    public override void Start()
    {
        lifetime = 0.5f;
    }
    public override void Update()
    {
        LifeTime();
    }
}
