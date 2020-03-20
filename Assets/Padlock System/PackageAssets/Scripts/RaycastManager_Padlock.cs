using UnityEngine;
using System.Collections;

public class RaycastManager_Padlock : MonoBehaviour
{
    private GameObject raycasted_obj;

    [Header("Raycast Length/Layer")]
    [SerializeField] private int rayLength = 10;
    [SerializeField] private LayerMask layerMaskInteract;

    [Header("Crosshair Reference")]
    [SerializeField] private GameObject cHNormal;
    [SerializeField] private GameObject cHHighlight;

    void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, out hit, rayLength, layerMaskInteract.value))
        {
            if (hit.collider.CompareTag("CombiLock"))
            {
                raycasted_obj = hit.collider.gameObject;
                CrosshairActive();

                if (Input.GetKeyDown("e"))
                {
                    raycasted_obj.GetComponent<InteractObject>().ExaminableObject.SetActive(true);
                    this.enabled = false;
                }
            }
        }

        else
        {
            CrosshairNormal();
        }
    }

    void CrosshairActive()
    {
        cHNormal.SetActive(false);
        cHHighlight.SetActive(true);
    }

    void CrosshairNormal()
    {
        cHNormal.SetActive(true);
        cHHighlight.SetActive(false);
    }
}
