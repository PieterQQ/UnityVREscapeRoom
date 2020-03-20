using UnityEngine;
using System.Collections;

public class OpenDoor : MonoBehaviour
{



    private float smooth = 2.0f;
    private float DoorOpenAngle = 90.0f;
    public bool open;


    private Vector3 defaultRot;
    private Vector3 openRot;
    void Start()
    {
        open = false;
    
        defaultRot = transform.eulerAngles;
        openRot = new Vector3(defaultRot.x, defaultRot.y + DoorOpenAngle, defaultRot.z);
    }

    void Update()
    {
        if (open)
        {
           
            transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, openRot, Time.deltaTime * smooth);
          

        }
       
    }
    public void Unlockdoors()
    {
     
        open = true;



    }
}
