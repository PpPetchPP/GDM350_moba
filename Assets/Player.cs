using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public UI_ingame uI_Ingame;

    public LayerMask Whatcanclick;
    public NavMeshAgent myAgent;
    public Material Ghost_walk_met;
    public Material defalt;

    Vector3 thispos;

    bool gw = false;

    void Start() 
    {
        myAgent = GetComponent<NavMeshAgent>();
        myAgent.speed = 5f;
        myAgent.angularSpeed = 1000f;
        myAgent.acceleration = 100f;
    }

    void Update() 
    {
        Move();
    }

    void Move()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(myRay, out hitInfo, 100, Whatcanclick))
            {
                myAgent.SetDestination(hitInfo.point);
            }
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            thispos = this.transform.position;
            myAgent.SetDestination(thispos);
        }
    }

    public void ghost_walk() 
    {
        gw = true;
        GetComponent<Renderer>().material = Ghost_walk_met;
    }
    public void ghost_walk_cancel()
    {
        if (gw == true) 
        {
            gw = false;
            GetComponent<Renderer>().material = defalt;
            myAgent.speed = 5;
        }
    }

    public void alacrity_cancel()
    {
        myAgent.speed = 5;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enermy" && gw == true)
        {
            myAgent.speed = 10;
        }
        if (collision.gameObject.tag == "Enermy" && gw == false ) 
        {
            uI_Ingame.Die();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Alacrity")
        {
            Debug.Log("Run");
            myAgent.speed = 10;
        }
    }

}
