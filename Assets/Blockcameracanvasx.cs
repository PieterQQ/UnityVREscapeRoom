using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blockcameracanvasx : MonoBehaviour {
    [SerializeField]
    private GvrReticlePointer FPSController;
    [SerializeField]
    private Canvas TestCanvas;
    [SerializeField]
    private bool isencanvas;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void isenabled()
    {
        FPSController.enabled = false;
       
    }
}
