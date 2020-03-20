//Script written by Matthew Rukas - Volumetric Games || volumetricgames@gmail.com || www.volumetric-games.com

using UnityEngine;
using System.Collections;

public class KeyController : MonoBehaviour
{
    private KeyPadController kpController;
    private KeyPadRay kpRay;

    void Start()
    {
        kpController = this.gameObject.GetComponent<KeyPadController>();
        kpRay = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<KeyPadRay>();
    }

    public void KeyPressNum(int keyNumber)
    {
        kpController.SingleBeep();

        if (kpController.codeText.characterLimit <= (kpController.characterLim - 1))
        {
            kpController.codeText.characterLimit++;
            kpController.codeText.text = kpController.codeText.text + keyNumber;
        }
    }

    public void KeyPressEnt()
    {
        kpController.CheckCode();
    }

    public void KeyPressClr()
    {
        kpController.SingleBeep();
        kpController.codeText.characterLimit = 0;
        kpController.codeText.text = string.Empty;
    }

    public void KeyPressClose()
    {
        kpController.SingleBeep();
        kpRay.EnablePlayer();
        kpRay.DisableUI();
    }
}
