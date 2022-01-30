using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsUnlock : MonoBehaviour
{



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            UnLockLevel();
            SceneManager.LoadScene(0);
        }
    }


    public void UnLockLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if (currentLevel >= PlayerPrefs.GetInt("levels"))
        {
            PlayerPrefs.SetInt("levels", currentLevel + 0);
        }
    }
}
