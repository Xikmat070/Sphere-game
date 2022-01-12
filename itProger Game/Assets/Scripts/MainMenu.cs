using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private string playerName;
    [SerializeField]
    private string saveName;
    public Text nameText;
    [SerializeField]
    private Text inputText;


    private void Update()
    {
        playerName = PlayerPrefs.GetString("name", playerName);
        nameText.text = playerName;
        
    }
    public void SetName()
    {
        saveName = inputText.text;
        PlayerPrefs.SetString("name", saveName);
        
    }

    public void LevelManager(string LevelNumber)
    {
        SceneManager.LoadScene(LevelNumber);
    }
}
