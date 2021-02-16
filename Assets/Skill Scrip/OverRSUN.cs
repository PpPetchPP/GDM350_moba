using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverRSUN : BasicSkill
{
    public override void Start()
    {
        lifetime = 2f;
    }
    public override void Update()
    {
        LifeTime();
        Invoke("Generrate", 1.7f);
    }
}
