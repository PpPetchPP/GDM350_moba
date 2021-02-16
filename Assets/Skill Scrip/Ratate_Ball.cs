using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ratate_Ball : MonoBehaviour
{
    void Update()
    {
        this.transform.Rotate(Vector3.up*100*Time.deltaTime);
    }
}
