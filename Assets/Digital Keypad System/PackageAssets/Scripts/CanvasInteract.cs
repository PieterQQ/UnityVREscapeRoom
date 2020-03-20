//Script written by Matthew Rukas - Volumetric Games || volumetricgames@gmail.com || www.volumetric-games.com

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CanvasInteract : MonoBehaviour
{
    [SerializeField] private Canvas keyPadCanvas;
    public void Start()
    {
        keyPadCanvas.enabled = false;
    }
    public void CanvasOn()
    {
        if (keyPadCanvas.enabled)
        {
            keyPadCanvas.enabled = false;
        }
        else
        keyPadCanvas.enabled = true;
    }

    public void CanvasOff()
    {
        if (keyPadCanvas.enabled)
        keyPadCanvas.enabled = false;
    }
}
