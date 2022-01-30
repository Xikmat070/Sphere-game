/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;


public class PlayerData : MonoBehaviour
{
    public Text scoretext;
    public string pname;
    public Text namel;
    public Text topscore;
    public SaveName naim;
    public SaveCoins bestscore;
    public int score;
    public string path = @"C:\Users\user\Desktop\TopScore.txt";
    private void Update()
    {
        SaveText();
        TopScore();
    }

    
    public void SaveText()
    {
        
        if (File.Exists(path))
        {
            
            naim.playerName = pname;
            bestscore.bestcoin = score;
            
            using (StreamWriter save = new StreamWriter(path))
            {
                
                save.WriteLine(pname + " " + score + "\n");
                save.Close();
            }
        
        }
        
    }

    public void TopScore()
    {
        using (StreamReader sr = File.OpenText(path))
        {
            string s = "";

            for (s = sr.ReadLine(); s != null; s = s + 1)
            {

                scoretext.text = s.ToString();
               
                break;

            }



            

        }
    
    }

}*/
