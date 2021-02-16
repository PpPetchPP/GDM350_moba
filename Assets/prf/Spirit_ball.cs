using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spirit_ball : MonoBehaviour
{
    public int speed = 10;
    public float lifetime = 3;
    void Start()
    {
        
    }

    void Update()
    {
        this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        lifetime -= Time.deltaTime;
        if (lifetime<=0) 
        {
            Destroy(this.gameObject);
        }
    }
}
