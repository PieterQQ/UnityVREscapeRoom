using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Cuberotate : MonoBehaviour {

    // Use this for initialization
    public float spinForce=0;
    public float gazeTime = 5f;
    public float timer;
    public bool gazedAt;
    public Transform cube;
    void Start () {
       
	}
    
    // Update is called once per frame
    void Update()
    {
        changespin();

        if (gazedAt)
        {
            
            timer += Time.deltaTime;

            if (timer >= gazeTime)
            {
                
                changespin();

            }
            else
            { stopspin(); }
        }
    }

    public void stopspin()
    {
        spinForce = 0;
    }

    public void changespin()
    {
       

        spinForce = 45;
        cube.Rotate(0, spinForce, 0);
    }
        


    public void PointerEnter()
{
        gazedAt = true;
        Debug.Log("PointerEnter");
    
}

public void PointerExit()
{
    gazedAt = false;
     
        Debug.Log("PointerExit");
}

public void PointerDown()
{
      
        Debug.Log("PointerDown");
}
}
