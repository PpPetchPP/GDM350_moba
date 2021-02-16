using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverREMP : BasicSkill
{
    public override void Start()
    {
        lifetime = 3f;
    }
    public override void Update()
    {   
        LifeTime();
        Invoke("Generrate", 2.9f);
    }
}
