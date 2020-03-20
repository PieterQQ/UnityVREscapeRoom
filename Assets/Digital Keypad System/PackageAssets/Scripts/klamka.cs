using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class klamka : MonoBehaviour
{
   
    private float smooth = 15.1f;
    private float DoorOpenAngle = 30.0f;
    public bool open;
    public Animator anim;

    private Vector3 defaultRot;
    private Vector3 openRot;

    void Start()
    {
        open = false;
        anim = GetComponent<Animator>();
        defaultRot = transform.eulerAngles;
        openRot = new Vector3(defaultRot.x , defaultRot.y , defaultRot.z + DoorOpenAngle);
    }

    // Update is called once per frame
    void Update()
    {
        if (open)
        {
        
            anim.Play("New Animation",-1);      
           
            // transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, openRot, Time.deltaTime * smooth);
           
            //transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, new Vector3(defaultRot.x, defaultRot.y, defaultRot.z), Time.deltaTime * smooth);

        }
    }
    public void tryopen()
    {
        open = true;
    }
}
