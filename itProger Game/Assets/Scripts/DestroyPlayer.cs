using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroyPlayer : MonoBehaviour
{
    [SerializeField]
    private SaveCoins playercoins;

    private UnityEngine.Object explosion;
    [SerializeField]
    private AudioSource AudioDestroy;


    private void Start()
    {
        explosion = Resources.Load("Explosion");
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Cube")
        {
            
            playercoins.PlayerCoins();
    
            PlayerPrefs.SetInt("coins", 0);
           
            Lose.isGameOver = true;

            
            GameObject explosionRef = (GameObject)Instantiate(explosion);
            explosionRef.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            

            Destroy(gameObject);
            AudioDestroy.Play();
        }
    
    }

}
