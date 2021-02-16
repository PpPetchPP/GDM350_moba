using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BasicSkill : MonoBehaviour
{
    public GameObject player;
    public NavMeshAgent forge_spirit;

    public int speed = 1;
    public float lifetime = 5f;
    public float delaytime = 1f;

    bool gen = true;

    public GameObject Particle_skill;

    public virtual void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        forge_spirit = GetComponent<NavMeshAgent>();
    }

    public virtual void Update()
    {
        
    }

    public void LifeTime() 
    {
        lifetime -= Time.deltaTime;
        if (lifetime <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    public void move()
    {
        this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    public void Generrate() 
    {
        if (gen == true) 
        {
            Instantiate(Particle_skill, this.transform.position, this.transform.rotation);
            gen = false;
        }
    }
}
