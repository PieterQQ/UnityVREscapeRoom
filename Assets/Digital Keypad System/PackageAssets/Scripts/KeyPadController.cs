//Script written by Matthew Rukas - Volumetric Games || volumetricgames@gmail.com || www.volumetric-games.com

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class KeyPadController : MonoBehaviour
{
    [SerializeField] private string validCode;
    public int characterLim;
    public InputField codeText;

    [SerializeField] private GameObject door;
    [SerializeField] private GameObject keypadModel;

    [SerializeField] private AudioClip beep; 
    [SerializeField] private AudioClip denied;
    private AudioSource mainAudio;

    void Start()
    {
        mainAudio = GetComponent<AudioSource>();
    }

    public void SingleBeep()
    {
            mainAudio.PlayOneShot(beep, 0.2f); 
    }

    public void CheckCode()
    {
        if (codeText.text == validCode)
        {
            door.GetComponent<OpenDoor>().open = true;
            keypadModel.tag = "Untagged"; 
        }

        else
        {
            mainAudio.PlayOneShot(denied, 0.2f);
        }
    }
}
