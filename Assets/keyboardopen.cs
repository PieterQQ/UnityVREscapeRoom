using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keyboardopen : MonoBehaviour
{
  
    [SerializeField]
    private Text keyboardinput;
    [SerializeField]
    public string correctanswer;

    public Animator szafa;

    private Vector3 defaultRot;
    private Vector3 openRot;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void checkifcorrect()
    {


        if (keyboardinput.text.Contains(correctanswer))
        {
            szafa.Play("New Animationszefa");
        }
    }
   
}

