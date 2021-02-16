using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillTest : MonoBehaviour
{
    public BaseSkill baseSkill;
    public Player playerscrip;
    public Image image_D;
    public Image image_F;

    public Sprite[] iconskill = new Sprite[10];
    public string[] skill_slot = new string[3] {"","",""};
    public string[] All_Skill = new string[10] { "Cold Snap", "Ghost Walk", "Ice Wall", "E.M.P.", "Tornado", "Alacrity", "Sun Strike", "Forge Spirit", "Chaos Meteor", "Daefening Blast" };
    public string[] skill_df = new string[2] { "", ""};

    void Update()
    {
        UseSkillKey();
    }

    void check() 
    {
        foreach (string slot in skill_slot) 
        {
            Debug.Log("Skill in slot = "+slot);
        }

        if (skill_slot[0] == "Quas" && skill_slot[1] == "Quas" && skill_slot[2] == "Quas")  //Cold Snap 0 / 2
        {
            Next_DF(All_Skill[0],0);
        }
        if ((skill_slot[0] == "Quas" && skill_slot[1] == "Quas" && skill_slot[2] == "Wex") ||  //Ghost Walk 1 / 10
            (skill_slot[0] == "Quas" && skill_slot[1] == "Wex" && skill_slot[2] == "Quas") || 
            (skill_slot[0] == "Wex" && skill_slot[1] == "Quas" && skill_slot[2] == "Quas"))
        {
            Next_DF(All_Skill[1],1);
        }
        if ((skill_slot[0] == "Quas" && skill_slot[1] == "Quas" && skill_slot[2] == "Exort") ||  //Ice Wall 2 / 6
            (skill_slot[0] == "Quas" && skill_slot[1] == "Exort" && skill_slot[2] == "Quas") || 
            (skill_slot[0] == "Exort" && skill_slot[1] == "Quas" && skill_slot[2] == "Quas"))
        {
            Next_DF(All_Skill[2],2);
        }

        if (skill_slot[0] == "Wex" && skill_slot[1] == "Wex" && skill_slot[2] == "Wex")     //E.M.P. 3 / 7
        {
            Next_DF(All_Skill[3],3);
        }
        if ((skill_slot[0] == "Wex" && skill_slot[1] == "Wex" && skill_slot[2] == "Quas") ||    //Tornado 4 / 5
            (skill_slot[0] == "Wex" && skill_slot[1] == "Quas" && skill_slot[2] == "Wex") ||  
            (skill_slot[0] == "Quas" && skill_slot[1] == "Wex" && skill_slot[2] == "Wex"))
        {
            Next_DF(All_Skill[4],4);
        }
        if ((skill_slot[0] == "Wex" && skill_slot[1] == "Wex" && skill_slot[2] == "Exort") ||   //Alacrity 5 / 15
            (skill_slot[0] == "Wex" && skill_slot[1] == "Exort" && skill_slot[2] == "Wex") || 
            (skill_slot[0] == "Exort" && skill_slot[1] == "Wex" && skill_slot[2] == "Wex"))
        {
            Next_DF(All_Skill[5],5);
        }

        if (skill_slot[0] == "Exort" && skill_slot[1] == "Exort" && skill_slot[2] == "Exort")   //Sun Strike 6 / 3
        {
            Next_DF(All_Skill[6],6);
        }
        if ((skill_slot[0] == "Exort" && skill_slot[1] == "Exort" && skill_slot[2] == "Quas") ||  //Forge Spirit 7 / 12
            (skill_slot[0] == "Exort" && skill_slot[1] == "Quas" && skill_slot[2] == "Exort") || 
            (skill_slot[0] == "Quas" && skill_slot[1] == "Exort" && skill_slot[2] == "Exort"))
        {
            Next_DF(All_Skill[7],7);
        }
        if ((skill_slot[0] == "Exort" && skill_slot[1] == "Exort" && skill_slot[2] == "Wex") ||   //Chaos Meteor 8 / 5
            (skill_slot[0] == "Exort" && skill_slot[1] == "Wex" && skill_slot[2] == "Exort") || 
            (skill_slot[0] == "Wex" && skill_slot[1] == "Exort" && skill_slot[2] == "Exort"))
        {
            Next_DF(All_Skill[8],8);
        }

        if ((skill_slot[0] == "Quas" && skill_slot[1] == "Wex" && skill_slot[2] == "Exort") ||  //Daefening Blast 9 / 5
            (skill_slot[0] == "Quas" && skill_slot[1] == "Exort" && skill_slot[2] == "Wex") || 
            (skill_slot[0] == "Wex" && skill_slot[1] == "Quas" && skill_slot[2] == "Exort") || 
            (skill_slot[0] == "Wex" && skill_slot[1] == "Exort" && skill_slot[2] == "Quas") || 
            (skill_slot[0] == "Exort" && skill_slot[1] == "Quas" && skill_slot[2] == "Wex") ||
            (skill_slot[0] == "Exort" && skill_slot[1] == "Wex" && skill_slot[2] == "Quas"))
        {
            Next_DF(All_Skill[9],9);
        }
    }

    void UseSkillKey() 
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Next("Quas");
            Debug.Log("Skill : Quas");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Next("Wex");
            Debug.Log("Skill : Wex");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Next("Exort");
            Debug.Log("Skill : Exort");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            check();
        }

        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Use Skill = " + skill_df[0]);
            baseSkill.readyskill(skill_df[0]);
        }
        if (Input.GetKey(KeyCode.F))
        {
            Debug.Log("Use Skill = " + skill_df[1]);
            baseSkill.readyskill(skill_df[1]);
        }
    }
    void Next_DF(string newskill_form_R,int number) 
    {
        playerscrip.ghost_walk_cancel();
        if (skill_df[0] != newskill_form_R) 
        {
            skill_df[1] = skill_df[0];
            skill_df[0] = newskill_form_R;

            image_F.sprite = image_D.sprite;
            image_D.sprite = iconskill[number];

            baseSkill.show_cooldown_d(number);
        }
    }

    void Next(string newskill) 
    {
        playerscrip.ghost_walk_cancel();
        skill_slot[2] = skill_slot[1];
        skill_slot[1] = skill_slot[0];
        skill_slot[0] = newskill;
    }
}
