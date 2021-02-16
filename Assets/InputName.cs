using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InputName : MonoBehaviour
{
    public GameManage gameManage;
    public Text inputname;
    public void Submit() 
    {
        gameManage.SavePlayer_Name(inputname.text);
        SceneManager.LoadScene(1);
    }
}
