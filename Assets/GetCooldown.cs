using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class GetCooldown : MonoBehaviour
{
    string ConfigdataFileName;
    int[] getcooldown = new int[10];
    int[] numberskill = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    private void Awake()
    {
        ConfigdataFileName = @"D:/Test/SkillCoolDown.csv";
    }

    void Start()
    {
        ReadConfix();
    }

    
    void Update()
    {
        
    }

    void ReadConfix() 
    {
        StreamReader input = null;
        try
        {
            input = File.OpenText(Path.Combine(Application.streamingAssetsPath, ConfigdataFileName));

            string name = input.ReadLine();

            string values = input.ReadLine();

            while (values != null)
            {
                SetConf(values);
                values = input.ReadLine();
            }
        }
        catch (Exception e)
        {
            print(e.Message);
        }
        finally
        {
            if (input != null)
            {
                input.Close();
            }
        }
    }

    void SetConf(string csvValue)
    {
        string[] values = csvValue.Split(',');

        for (int x = 0; x < numberskill.Length; x++) 
        {
            if (numberskill[x] == int.Parse(values[0]))
            {
                getcooldown[x] = int.Parse(values[1]);
            }
        }
    }

    public int GetCooldownForUse(int numberskill) 
    {
        return getcooldown[numberskill];
    }
}
