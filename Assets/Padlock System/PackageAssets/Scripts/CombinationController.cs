using UnityEngine;
using System.Collections;

public class CombinationController : MonoBehaviour
{
    [Header("Your Inputs")]
    [SerializeField] private string playerCombi;
    [SerializeField] private string yourCombination;
    private bool hasUnlocked;

    //Hiddie from the inspector because these are only integers to hold some information for later.
    [HideInInspector] public int combinationRow1;
    [HideInInspector] public int combinationRow2;
    [HideInInspector] public int combinationRow3;
    [HideInInspector] public int combinationRow4;

    [Header("Audio Refenences")]
    [SerializeField] private AudioClip spinSound;
    [SerializeField] private AudioClip unlockSound;
    [SerializeField] private AudioClip interactSound;
    private AudioSource mainAudio; //Private declaration to the audiosource component

    [Header("Player References")]
    [SerializeField] private Camera mainCamera;
    [SerializeField] private GameObject player;

    [Header("GameObject References")]
    [SerializeField] private GameObject interactableLock;
   // [SerializeField] private Canvas crosshairCanvas;
    [SerializeField] private Animator lockAnim;

    void Awake()
    {
        mainAudio = GetComponent<AudioSource>(); //Finds the AudioSource on the GameObject
        combinationRow1 = 1;
        combinationRow2 = 1;
        combinationRow3 = 1;
        combinationRow4 = 1;
    }

    void OnEnable()
    {
        //FPSController stops the player moving, can be replaced if you're using your own controller
      //  player.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = false;

      //  mainCamera.transform.localEulerAngles = new Vector3(0, 0, 0);
        HideCursor();
        InteractSound();
    }

    void UnlockDoor()
    {
        //DO YOUR DOOR UNLOCKING OR WHATEVER RESULT OF THE PADLOCK COMBINATION BEING CORRECT THAT YOU WANT!
    }

    void Disable()
    {
        //FPSController enabled allows the player to move again, can be replaced if you're using your own controller
      //  player.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = true;

        ShowCursor();
       // mainCamera.GetComponent<RaycastManager_Padlock>().enabled = true;
        this.gameObject.SetActive(false);
    }

    IEnumerator CorrectCombination()
    {
        lockAnim.Play("LockOpen");
        UnlockSound();
        UnlockDoor();
        yield return new WaitForSeconds(1.2f);
        interactableLock.SetActive(false);

        //FPSController enabled allows the player to move again, can be replaced if you're using your own controller
      //  player.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = true;

      //  mainCamera.GetComponent<RaycastManager_Padlock>().enabled = true;
        ShowCursor();
        this.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            Disable();
        }

        playerCombi = combinationRow1.ToString("0") + combinationRow2.ToString("0") + combinationRow3.ToString("0") + combinationRow4.ToString("0");

        if (playerCombi == yourCombination)
        {
            if (!hasUnlocked)
            {
                StartCoroutine(CorrectCombination());
                hasUnlocked = true;
            }
        }
    }

    void HideCursor()
    {
     //   crosshairCanvas.enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void ShowCursor()
    {
      //  crosshairCanvas.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void InteractSound()
    {
        mainAudio.PlayOneShot(interactSound, 0.25f);
    }

    public void SpinSound()
    {
        mainAudio.PlayOneShot(spinSound, 0.2f);
    }

    public void UnlockSound()
    {
        mainAudio.PlayOneShot(unlockSound, 0.25f);
    }
}
