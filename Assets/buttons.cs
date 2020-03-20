using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttons : MonoBehaviour
{
    [SerializeField]
    private InputField CodeInputField;
    [SerializeField]
    private int NumberLimit;
    [SerializeField]
    private string AccessCode;
    [SerializeField]
    public Transform door;

    [SerializeField]
    public Canvas canvas;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Button0()
    {
        if (CodeInputField.text.Length < NumberLimit)
            CodeInputField.text += "0";
        else
            CodeInputField.text = "Only " + NumberLimit.ToString() + " digits";
    }
    public void Button1()
    {
        if (CodeInputField.text.Length < NumberLimit)
            CodeInputField.text += "1";
        else
            CodeInputField.text = "Only " + NumberLimit.ToString() + " digits";
    }
    public void Button2()
    {
        if (CodeInputField.text.Length < NumberLimit)
            CodeInputField.text += "2";
        else
            CodeInputField.text = "Only " + NumberLimit.ToString() + " digits";
    }
    public void Button3()
    {
        if (CodeInputField.text.Length < NumberLimit)
            CodeInputField.text += "3";
        else
            CodeInputField.text = "Only " + NumberLimit.ToString() + " digits";
    }
    public void Button4()
    {
        if (CodeInputField.text.Length < NumberLimit)
            CodeInputField.text += "4";
        else
            CodeInputField.text = "Only " + NumberLimit.ToString() + " digits";
    }
    public void Button5()
    {
        if (CodeInputField.text.Length < NumberLimit)
            CodeInputField.text += "5";
        else
            CodeInputField.text = "Only " + NumberLimit.ToString() + " digits";
    }
    public void Button6()
    {
        if (CodeInputField.text.Length < NumberLimit)
            CodeInputField.text += "6";
        else
            CodeInputField.text = "Only " + NumberLimit.ToString() + " digits";
    }
    public void Button7()
    {
        if (CodeInputField.text.Length < NumberLimit)
            CodeInputField.text += "7";
        else
            CodeInputField.text = "Only " + NumberLimit.ToString() + " digits";
    }
    public void Button8()
    {
        if (CodeInputField.text.Length < NumberLimit)
            CodeInputField.text += "8";
        else
            CodeInputField.text = "Only " + NumberLimit.ToString() + " digits";
    }
    public void Button9()
    {
        if (CodeInputField.text.Length < NumberLimit)
            CodeInputField.text += "9";
        else
            CodeInputField.text = "Only " + NumberLimit.ToString() + " digits";
    }
    public void ButtonClear() { CodeInputField.text = ""; }
    public void ButtonOK()
    {
        if (CodeInputField.text.Contains(AccessCode))
        {

            door.GetComponent<OpenDoor>().open = true;
        }


    }
    public void ButtonESC()
    {
        canvas.enabled = false;
    }
}