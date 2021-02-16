using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Enermy : MonoBehaviour
{
    public CheckSpawn checkSpawn;
    public GameObject player;
    protected NavMeshAgent enermyai;
    public Image candie_by_icon;
    protected Rigidbody rb;

    public Sprite[] iconskill = new Sprite[8];
    public bool[] candie = new bool[8];
    public virtual void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
        checkSpawn = GameObject.Find("Canvas").GetComponent<CheckSpawn>();
        enermyai = GetComponent<NavMeshAgent>();
        setCanDie();
    }

    protected void Update()
    {
        enermyai.SetDestination(player.transform.position);
    }

    protected void setCanDie()
    {
        Destroy(candie_by_icon);
        candie[0] = true;
        candie[1] = true;
        candie[2] = true;
        candie[3] = true;
        candie[4] = true;
        candie[5] = true;
        candie[6] = true;
        candie[7] = true;
    }

    public void randomcandie()
    {
        int x = Random.Range(0, 7);
        candie[x] = true;
        candie_by_icon.sprite = iconskill[x];
    }

    protected void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Tornado" && candie[0] == false)
        {
            Slow_effect(2f, 5);
        }
        if (other.gameObject.tag == "Daefening Blast" && candie[3] == false)
        {
            Slow_effect(3f, 3);
            player = GameObject.FindGameObjectWithTag("Daefening Blast");
        }
        if (other.gameObject.tag == "Ice Wall" && candie[4] == false)
        {
            Slow_effect(0.5f,4);
        }
        if (other.gameObject.tag == "Cold Snap" && candie[5] == false)
        {
            Slow_effect(0f, 1);
        }
        if (other.gameObject.tag == "Chaos Meteor" && candie[6] == false)
        {
            Slow_effect(2f, 5);
        }


        if (other.gameObject.tag == "Tornado" && candie[0] == true)
        {
            die();
        }
        if (other.gameObject.tag == "Sun Strike" && candie[1] == true)
        {
            die();
        }
        if (other.gameObject.tag == "E.M.P." && candie[2] == true)
        {
            die();
        }
        if (other.gameObject.tag == "Daefening Blast" && candie[3] == true)
        {
            die();
        }
        if (other.gameObject.tag == "Ice Wall" && candie[4] == true)
        {
            die();
        }
        if (other.gameObject.tag == "Cold Snap" && candie[5] == true)
        {
            die();
        }
        if (other.gameObject.tag == "Chaos Meteor" && candie[6] == true)
        {
            die();
        }
        if (other.gameObject.tag == "Spirit Ball" && candie[7] == true)
        {
            die();
        }
    }
    public void Slow_effect(float speed,int timer) 
    {
        enermyai.speed = speed;
        Invoke("Cancle_all_debuff", timer);
    }
    public void Cancle_all_debuff() 
    {
        enermyai.speed = 3;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void die()
    {
        checkSpawn.count_die_enermy();
        Destroy(this.gameObject);
    }
}
