using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendeks : MonoBehaviour
 {
    [SerializeField]
    public AudioClip opensound;
    [SerializeField]
    public AudioClip closesound;
    [SerializeField]
    public AudioClip closedsound;
    public GameObject locker;
  
    [SerializeField]
    private float distance;
    public bool open;
    public int openstart;
    private Vector3 defaultpos;
    private Vector3 targetpos;
    public GameObject desk;
    float ElapsedTime;
    float FinishTime;
    public CombinationController control;
    void Start()
    {
        
        open = false;
        defaultpos = desk.transform.position;
        targetpos = new Vector3(defaultpos.x , defaultpos.y, defaultpos.z + distance);

        ElapsedTime = 0;
        FinishTime = 1.3f;
       
     
    }

void Update()
{

        if (open&& GameObject.Find("Locker") == null)
        {
            openstart = 1;
             ElapsedTime += Time.deltaTime;
           //open desk
            desk.transform.position = Vector3.Lerp(defaultpos, targetpos, ElapsedTime / FinishTime);
          
          
        }
        else if (!open && openstart>0 && GameObject.Find("Locker") == null)
        {
            //close desk
          
            ElapsedTime += Time.deltaTime;
            desk.transform.position = Vector3.Lerp(targetpos, defaultpos, ElapsedTime / FinishTime);
            
        }
    }
    
   public void Unlockdesk()
    {
        ElapsedTime = 0;
        if (open && GameObject.Find("Locker") == null)
        {
            AudioSource.PlayClipAtPoint(closesound, new Vector3(defaultpos.x, defaultpos.y, defaultpos.z + distance));
            open = !open;
        }
        else if (!open && GameObject.Find("Locker") == null)
        {
            AudioSource.PlayClipAtPoint(opensound, new Vector3(defaultpos.x, defaultpos.y, defaultpos.z + distance));
            open = !open;
        }
        else if (!open && GameObject.Find("Locker") != null)
        {
            AudioSource.PlayClipAtPoint(closedsound, new Vector3(defaultpos.x, defaultpos.y, defaultpos.z + distance));
        }
       

       
    }
  
}

    
    
  
    
