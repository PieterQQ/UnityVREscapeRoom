using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboardonoff : MonoBehaviour
{
    public GameObject keyboard;
    // Start is called before the first frame update
    void Start()
    {
        keyboard.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onoff()
    {
        if (keyboard.active==false)
        {
            keyboard.SetActive(true);
        }
        else
            keyboard.SetActive(false);
    }
}
