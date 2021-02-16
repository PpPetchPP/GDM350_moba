using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class OverREnermy : Enermy
{
    public override void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
        checkSpawn = GameObject.Find("Canvas").GetComponent<CheckSpawn>();
        enermyai = GetComponent<NavMeshAgent>();
        randomcandie();
    }
}
