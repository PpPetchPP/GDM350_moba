using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverRFORGE : BasicSkill
{
    public override void Start()
    {
        base.Start();
    }

    public override void Update()
    {
        forge_spirit.SetDestination(player.transform.position + new Vector3(2,0,2));
        LifeTime();
    }
}
