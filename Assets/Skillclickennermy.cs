using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skillclickennermy : MonoBehaviour
{
    public LayerMask Whatcanclick;
    public GameObject Cold_Snap;
    public GameObject Alacrity;
    public BaseSkill baseSkill;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void checkclick(string nameskill) 
    {
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if (Physics.Raycast(myRay, out hitInfo, 30,Whatcanclick))
        {
            if (hitInfo.collider.CompareTag("Enermy") && nameskill == "Cold Snap")
            {
                Instantiate(Cold_Snap,hitInfo.point, Cold_Snap.transform.rotation);
                baseSkill.Check_Cold_Snap();
            }
            if (hitInfo.collider.CompareTag("Player") && nameskill == "Alacrity")
            {
                Instantiate(Alacrity, hitInfo.point, Alacrity.transform.rotation);
                baseSkill.timeskillalacrity = 10f;
                baseSkill.onoffskill_al = true;
                baseSkill.Check_Alacrity();
            }
        }
    }
}
