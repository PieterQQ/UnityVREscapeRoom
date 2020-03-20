using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class padlockscript : MonoBehaviour {

    [SerializeField]
    private GameObject padlock;

    public void PadlockON()
    {
        padlock.SetActive(true);
    }

    public void PadlockOff()
    {
        padlock.SetActive(false);
    }
}
