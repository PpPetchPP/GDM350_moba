using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.IO;

public class UI_ingame : MonoBehaviour
{
    public GameManage gameManage;

    public Text name_text;
    public Text score_text;

    float time_float;
    float time_float_floor;

    float last_score;
    void Start()
    {
        name_text.text = "Name = "+gameManage.LoadPlayer_Name();
        EventManager.AddCheckSpawnListener(AddScore);
    }

    void Update()
    {
        time_float += 2 * Time.deltaTime;
        time_float_floor = Mathf.Floor(time_float);
        score_text.text = "Score = "+time_float_floor;
    }

    public void AddScore() 
    {
        time_float += 20;
    }

    public void Die() 
    {
        last_score = time_float_floor;
        if (last_score >= gameManage.LoadPlayer_Score())
        {
            string testnotepad = @"D:/Test/Name.txt";
            File.WriteAllText(testnotepad, name_text.text);
            string testnotepad_score = @"D:/Test/Score.txt";
            File.WriteAllText(testnotepad_score, score_text.text);
            gameManage.SavePlayer_Score(last_score);
        }

        Debug.Log(gameManage.LoadPlayer_Score());
        gameManage.chang_this_score(last_score);
        SceneManager.LoadScene(2);
    }
}
