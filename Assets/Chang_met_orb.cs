using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chang_met_orb : MonoBehaviour
{
    public SkillTest skillTest;
    public Material Q;
    public Material W;
    public Material E;
    public int NUmberOrb = 0;
    void Update()
    {
        if (skillTest.skill_slot[NUmberOrb] == "Quas") 
        {
            GetComponent<Renderer>().material = Q;
        }
        if (skillTest.skill_slot[NUmberOrb] == "Wex")
        {
            GetComponent<Renderer>().material = W;
        }
        if (skillTest.skill_slot[NUmberOrb] == "Exort")
        {
            GetComponent<Renderer>().material = E;
        }
    }
}
