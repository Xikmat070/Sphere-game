using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjects : MonoBehaviour
{
    
    [SerializeField]
    private GameObject[] CoinsRotate;
    [SerializeField]
    private GameObject[] capsuleRotate;
    [SerializeField]
    private GameObject[] cylinderRotate;
    [SerializeField]
    private GameObject[] cubeRotate;
    [SerializeField]
    private float speed = 1;
    
        
    
    void FixedUpdate()
    {

        RotateFunction();

    }

    void RotateFunction()
    {
        for(int i = 0; i < CoinsRotate.Length; i++)
        {
            CoinsRotate[i].transform.Rotate(0, 0, 0.1f * speed);
        }
        
        for(int i = 0; i < cubeRotate.Length; i++)
        {
            cubeRotate[i].transform.Rotate(0, 0.1f * speed, 0);
        }

        for (int i = 0; i < capsuleRotate.Length; i++)
        {
            capsuleRotate[i].transform.Rotate(0.1f * speed, 0, 0);
        }
        
        for(int i = 0; i < cylinderRotate.Length; i++)
        {
            cylinderRotate[i].transform.Rotate(0, 0.1f * speed, 0);
        }
        

        
    }

}
