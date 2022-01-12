using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveName : MonoBehaviour
{
    
    public string playerName;
    
    public Text textName;
    public PlayerData nameee;


    
    private void Start()
    {
        playerName = PlayerPrefs.GetString("name");
        textName.text = playerName.ToString();
        nameee.pname = playerName;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
