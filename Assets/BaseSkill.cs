using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseSkill : MonoBehaviour
{
    public LayerMask Whatcanclick;
    public GetCooldown getCooldown;

    public GameObject player;
    public Player playerscrip;
    public Skillclickennermy skillclickennermy;

    public GameObject tornado;
    public GameObject meteor;
    public GameObject sun_strike;
    public GameObject emp;
    public GameObject daefening_blast;
    public GameObject ice_wall;
    public GameObject forge_sprite;

    public SkillTest skillTest;
    public Text cooldown_D;
    public Text cooldown_F;

    string nameskill;
    int[] cooldownskill = new int[10] { 2, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
    public float[] timeskill = new float[10];

    float timeskillghostwalk = 5f;
    public float timeskillalacrity = 10f;

    Vector3 targetpos;

    public Vector3 offsettornado;
    public Vector3 offsetmeteor;
    public Vector3 offsetemp;
    public Vector3 offseticewall;

    bool onoffskill = false;
    bool onoffskill_gw = false;
    public bool onoffskill_al = false;
    public bool[] ontimecooldown = new bool[10] {true,true,true,true,true,true,true,true,true,true};


    void Start()
    {
        for (int x = 0;x<10;x++) 
        {
            cooldownskill[x] = getCooldown.GetCooldownForUse(x);
            Debug.Log("cooldown " + x + " = " + cooldownskill[x]);
        }
    }
    void Update()
    {
        if (onoffskill == true) 
        {
            UseSkill();
        }
        if (onoffskill_gw == true) 
        {
            Check_Ghost_walk();
        }
        if (onoffskill_al == true)
        {
            Check_Alacrity_buff();
        }
        CheckCooldown();
    }

    public void readyskill(string skill) 
    {
        nameskill = skill;
        onoffskill = true;
    }
    void UseSkill() 
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            playerscrip.ghost_walk_cancel();

            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(myRay, out hitInfo, 30,Whatcanclick))
            {
                targetpos = new Vector3(hitInfo.point.x, hitInfo.point.y, hitInfo.point.z);

                transform.LookAt(targetpos);

                CheckSkill(nameskill);
            }
        }
        if (Input.GetMouseButtonDown(1)) 
        {
            onoffskill = false;
        }
    }
    void CheckSkill(string nameskill) 
    {
        if (nameskill == skillTest.All_Skill[0] && ontimecooldown[0] == true)
        {
            Skill_Cold_Snap();
        }
        else if (nameskill == skillTest.All_Skill[1] && ontimecooldown[1] == true)
        {
            Skill_Ghost_Walk();
            ontimecooldown[1] = false;
            timeskill[1] = 0;
        }
        else if (nameskill == skillTest.All_Skill[2] && ontimecooldown[2] == true)
        {
            Skill_Ice_Wall();
            ontimecooldown[2] = false;
            timeskill[2] = 0;
        }
        else if (nameskill == skillTest.All_Skill[3] && ontimecooldown[3] == true)
        {
            Skill_EMP();
            ontimecooldown[3] = false;
            timeskill[3] = 0;
        }
        else if (nameskill == skillTest.All_Skill[4] && ontimecooldown[4] == true)
        {
            Skill_tornado();
            ontimecooldown[4] = false;
            timeskill[4] = 0;
        }
        else if (nameskill == skillTest.All_Skill[5] && ontimecooldown[5] == true)
        {
            Skill_Alacrity();
        }
        else if (nameskill == skillTest.All_Skill[6] && ontimecooldown[6] == true)
        {
            Skill_Sun_Strike();
            ontimecooldown[6] = false;
            timeskill[6] = 0;
        }
        else if (nameskill == skillTest.All_Skill[7] && ontimecooldown[7] == true)
        {
            Skill_Forge_Sprite();
            ontimecooldown[7] = false;
            timeskill[7] = 0;
        }
        else if (nameskill == skillTest.All_Skill[8] && ontimecooldown[8] == true)
        {
            Skill_Meteor();
            ontimecooldown[8] = false;
            timeskill[8] = 0;
        }
        else if (nameskill == skillTest.All_Skill[9] && ontimecooldown[9] == true)
        {
            Skill_Daefening_Blast();
            ontimecooldown[9] = false;
            timeskill[9] = 0;
        }

    }

    void CheckCooldown()
    {
        timeskill[0] += Time.deltaTime;
        timeskill[1] += Time.deltaTime;
        timeskill[2] += Time.deltaTime;
        timeskill[3] += Time.deltaTime;
        timeskill[4] += Time.deltaTime;
        timeskill[5] += Time.deltaTime;
        timeskill[6] += Time.deltaTime;
        timeskill[7] += Time.deltaTime;
        timeskill[8] += Time.deltaTime;
        timeskill[9] += Time.deltaTime;

        if (timeskill[0] >= cooldownskill[0]) 
        {
            ontimecooldown[0] = true;
        }
        if (timeskill[1] >= cooldownskill[1])
        {
            ontimecooldown[1] = true;
        }
        if (timeskill[2] >= cooldownskill[2])
        {
            ontimecooldown[2] = true;
        }
        if (timeskill[3] >= cooldownskill[3])
        {
            ontimecooldown[3] = true;
        }
        if (timeskill[4] >= cooldownskill[4])
        {
            ontimecooldown[4] = true;
        }
        if (timeskill[5] >= cooldownskill[5])
        {
            ontimecooldown[5] = true;
        }
        if (timeskill[6] >= cooldownskill[6])
        {
            ontimecooldown[6] = true;
        }
        if (timeskill[7] >= cooldownskill[7])
        {
            ontimecooldown[7] = true;
        }
        if (timeskill[8] >= cooldownskill[8])
        {
            ontimecooldown[8] = true;
        }
        if (timeskill[9] >= cooldownskill[9])
        {
            ontimecooldown[9] = true;
        }
    }

    public void show_cooldown_d(int number)
    {
        if (skillTest.skill_df[0] == skillTest.All_Skill[number])
        {
            cooldown_F.text = cooldown_D.text;
            cooldown_D.text = cooldownskill[number].ToString();
        }        
    }

    void Check_Ghost_walk() 
    {
        timeskillghostwalk -= Time.deltaTime;
        if (timeskillghostwalk <= 0)
        {
            playerscrip.ghost_walk_cancel();
            onoffskill_gw = false;
        }
    }
    void Check_Alacrity_buff() 
    {
        timeskillalacrity -= Time.deltaTime;
        if (timeskillalacrity <= 0) 
        {
            playerscrip.alacrity_cancel();
            onoffskill_al = false;
        }
    }








    public void Check_Cold_Snap()
    {
        ontimecooldown[0] = false;
        timeskill[0] = 0;
    }
    public void Check_Alacrity()
    {
        ontimecooldown[5] = false;
        timeskill[5] = 0;
    }







    void Skill_tornado() 
    {
        Instantiate(tornado,player.transform.position + offsettornado,player.transform.rotation);
    }

    void Skill_Meteor() 
    {
        Instantiate(meteor, targetpos + offsetmeteor, player.transform.rotation);
    }

    void Skill_Sun_Strike() 
    {
        Instantiate(sun_strike, targetpos , sun_strike.transform.rotation);
    }

    void Skill_EMP()
    {
        Instantiate(emp, targetpos + offsetemp, emp.transform.rotation);
    }

    void Skill_Ghost_Walk() 
    {
        playerscrip.ghost_walk();
        timeskillghostwalk = 5f;
        onoffskill_gw = true;
    }

    void Skill_Ice_Wall()
    {
        Instantiate(ice_wall, player.transform.position + offseticewall,player.transform.rotation);
    }

    void Skill_Daefening_Blast() 
    {
        Instantiate(daefening_blast, player.transform.position + offsettornado, player.transform.rotation);
    }

    void Skill_Cold_Snap() 
    {
        skillclickennermy.checkclick("Cold Snap");
    }

    void Skill_Alacrity() 
    {
        skillclickennermy.checkclick("Alacrity");
    }

    void Skill_Forge_Sprite()
    {
        Instantiate(forge_sprite, player.transform.position, player.transform.rotation);
    }
}
