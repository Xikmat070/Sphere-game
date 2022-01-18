using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class SaveCoins : MonoBehaviour
{
    
    
    [SerializeField]
    private int coins;
    [SerializeField]
    private Text textcoins;
    public PlayerData scoreee;
    public int bestcoin;
    [SerializeField]
    private Text textbestcoin;
    [SerializeField]
    private int playercoins;
    [SerializeField]
    private Text playerscoretext;
    [SerializeField]
    private AudioSource coinAudio;
    private UnityEngine.Object coinexplosion;




    

    private void Awake()
    {
        
        if (PlayerPrefs.HasKey("SaveScore"))
        {
            bestcoin = PlayerPrefs.GetInt("SaveScore");
        }
        
    }


    private void Start()
    {
        coinexplosion = Resources.Load("CoinParticle");
    }

    private void Update()
    {
        if (PlayerPrefs.HasKey("coins"))
        {
            coins = PlayerPrefs.GetInt("coins");
            textcoins.text = coins.ToString();

        }

        BestCoin();
        

        if (PlayerPrefs.HasKey("coins"))
        {
            bestcoin = PlayerPrefs.GetInt("SaveScore");
            textbestcoin.text = bestcoin.ToString();


        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "money")
        {
            coinAudio.Play();
            coins++;

            GameObject explosionC = (GameObject)Instantiate(coinexplosion);
            explosionC.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            
            other.gameObject.SetActive(false);
            textcoins.text = coins.ToString();
            PlayerPrefs.SetInt("coins", coins);


            
        }
        

    }



    public void PlayerCoins()
    {
        int i = PlayerPrefs.GetInt("PlayerScore");

        playercoins = coins + i;
        
                
        PlayerPrefs.SetInt("PlayerScore", playercoins);

    }

    public void BestCoin()
    {

        
        if (coins > bestcoin)
        {
            bestcoin = coins;
        }
        PlayerPrefs.SetInt("SaveScore", bestcoin);

        scoreee.score = bestcoin;

        
    }
    
    

    public void ResetScore()
    {
        coins = 0;
    }
}
