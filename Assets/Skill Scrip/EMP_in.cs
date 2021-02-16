using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EMP_in : MonoBehaviour
{
    float lifetime = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lifetime -= Time.deltaTime;
        if (lifetime <= 0) 
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enermy") 
        {
            Destroy(this.gameObject);
        }
    }
}
