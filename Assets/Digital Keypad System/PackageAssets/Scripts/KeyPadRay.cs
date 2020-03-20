//Script written by Matthew Rukas - Volumetric Games || volumetricgames@gmail.com || www.volumetric-games.com

using UnityEngine;
using System.Collections;
//using UnityStandardAssets.Characters.FirstPerson; //Only use this if you're using the Standard asset FPS controller

public class KeyPadRay : MonoBehaviour
{
    [SerializeField] private GameObject crosshairN; 
    [SerializeField] private GameObject crosshairH; 

 //   [SerializeField] private FirstPersonController FPSController;
    [SerializeField] private LayerMask layerMaskInteract;

    private int rayLength = 10;
    private GameObject rayCastedObj; 

    void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        {
            if (Physics.Raycast(transform.position, fwd, out hit, rayLength, layerMaskInteract.value))
            {
                if (hit.collider.CompareTag("KeyPad")) 
                {
                    rayCastedObj = hit.collider.gameObject;
           
                    crosshairN.SetActive(false);
                    crosshairH.SetActive(true);

                    if (Input.GetKeyDown("e"))
                    {
                        rayCastedObj.GetComponent<CanvasInteract>().CanvasOn();
                        DisablePlayer();
                    }
                }
            }
            else
            {
                crosshairN.SetActive(true);
                crosshairH.SetActive(false);
            }
        }
    }

    public void DisableUI()
    {
        rayCastedObj.GetComponent<CanvasInteract>().CanvasOff();
    }

    void DisablePlayer()
    {
       // FPSController.enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void EnablePlayer()
    {   
        //FPSController.enabled = true; 
    }
}
