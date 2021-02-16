using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForgeSpiritAI : MonoBehaviour
{
    GameObject[] enermy;
    GameObject target;
    public GameObject spirit_attack;
    public GameObject spawn;
    int next_target = 0;
    void Start()
    {
        enermy = GameObject.FindGameObjectsWithTag ("Enermy");       
    }

    void Update()
    {
        target = enermy[next_target];
        try
        {
            this.transform.LookAt(target.transform);
        }
        catch 
        {
            if (next_target < enermy.Length - 1) 
            {
                next_target++;
            }
            Debug.Log("Taget = " + next_target);
        }
        if (Input.GetKeyDown(KeyCode.N)) 
        {
            next_target++;
        }
    }

    void Fire() 
    {
        Instantiate(spirit_attack, spawn.transform.position, spawn.transform.rotation);
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Enermy") 
        {
            if (!IsInvoking("Fire")) 
            {
                InvokeRepeating("Fire", 1, 1);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        CancelInvoke("Fire");
    }

}
