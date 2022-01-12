using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class Lose : MonoBehaviour
{
    [SerializeField]
    private int bestcoin;
    [SerializeField]
    private Text textbestcoin;
    [SerializeField]
    private int playercoins;
    [SerializeField]
    private Text playerscoretext;

    public static bool isGameOver;
    public GameObject gameoverscreen;

    private void Awake()
    {
        isGameOver = false;
    }

    private void Start()
    {
        bestcoin = PlayerPrefs.GetInt("SaveScore");
        textbestcoin.text = bestcoin.ToString();


        
        playercoins = PlayerPrefs.GetInt("PlayerScore");
        playerscoretext.text = playercoins.ToString();

    }
    private void Update()
    {
        if (isGameOver)
        {
            gameoverscreen.SetActive(true);
        }
    }



    public void LevelManager(string LevelNumber)
    {
        SceneManager.LoadScene(LevelNumber);
    }

}

