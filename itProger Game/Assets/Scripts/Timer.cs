using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public JoystickPlayerExample player;

    public GameObject[] cube;
    
    public int countdownTime;
    
    public Text countdownDisplay;

    private void Start()
    {
        
        StartCoroutine(CountdownToStart());
       
    }

    
    IEnumerator CountdownToStart()
    {
        player.gameObject.GetComponent<JoystickPlayerExample>().enabled = false;
        while (countdownTime > 0)
        {
            countdownDisplay.text = countdownTime.ToString();

            yield return new WaitForSeconds(1f);

            countdownTime--;
        }

              

        countdownDisplay.text = "Go!";

        player.gameObject.GetComponent<JoystickPlayerExample>().enabled = true;


        for (int  i = 0; i < cube.Length; i++)
        {
            cube[i].GetComponent<Renderer>().enabled = false;
        }
        

        

        yield return new WaitForSeconds(1f);

        countdownDisplay.gameObject.SetActive(false);
        
    }



}




