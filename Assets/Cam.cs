using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public Transform player;
    public Vector3 Offset;

    void Update()
    {
        Vector3 moveit = player.position + Offset;
        Vector3 smoth = Vector3.Lerp(transform.position, moveit, 0.125f);
        transform.position = smoth;
    }

}
