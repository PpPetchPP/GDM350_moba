using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using UnityEngine.SceneManagement;

public class UI_endgame : MonoBehaviour
{
    public GameManage gameManage;

    public Text this_score;
    public Text Hight_score;

    void Start()
    {
        string testnotepad = @"D:/Test/Name.txt";
        string name = File.ReadAllText(testnotepad);

        this_score.text = "Your Score = " + gameManage.get_thisscore();
        Hight_score.text = "Hight Score = " + gameManage.LoadPlayer_Score() + " By : " + name;
    }

    public void playagian() 
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
