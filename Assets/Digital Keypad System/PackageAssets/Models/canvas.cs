using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Canvas1 : MonoBehaviour
{
    [SerializeField]
    private GameObject Canvas;


    public void CanvasOn()
    {
        if (Canvas != null)
        {
            bool isActive = Canvas.activeSelf;
            Canvas.SetActive(!isActive);
        }

    }


}
