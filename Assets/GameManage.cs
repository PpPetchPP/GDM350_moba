  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManage : MonoBehaviour
{
    static float this_score;

    string playername_string;
    float score_Float;
    public void SavePlayer_Name(string playername) 
    {
        PlayerPrefs.SetString("PlayerName", playername);
    }
    public string LoadPlayer_Name() 
    {
        playername_string = PlayerPrefs.GetString("PlayerName");

        return playername_string;
    }

    public void SavePlayer_Score(float playerscore) 
    {
        PlayerPrefs.SetFloat("PlayerScore", playerscore);
    }
    public float LoadPlayer_Score() 
    {
        score_Float = PlayerPrefs.GetFloat("PlayerScore");

        return score_Float;
    }

    public void chang_this_score(float newscore) 
    {
        this_score = newscore;
    }

    public float get_thisscore() 
    {
        return this_score;
    }
}
