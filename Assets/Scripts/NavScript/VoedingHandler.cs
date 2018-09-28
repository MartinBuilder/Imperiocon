using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class VoedingHandler : MonoBehaviour
{
    public Button m_YourFirstButton;
    public bool isImgOn;
    public Image Dropdown;
    public Text Voedsel;
    public Text Koffie;
    public Text Thee;
    public Text Wijn;
    public Text Zuivel;

    void Start()
    {
        Button btn1 = m_YourFirstButton.GetComponent<Button>();

        //Calls the TaskOnClick/TaskWithParameters method when you click the Button
        btn1.onClick.AddListener(TaskOnClick);

        Dropdown.enabled = false;
        Voedsel.enabled = false;
        Koffie.enabled = false;
        Thee.enabled = false;
        Wijn.enabled = false;
        Zuivel.enabled = false;
        isImgOn = false;
    }

    void TaskOnClick()
    {
        //Output this to console when the Button is clicked
        Debug.Log("You have clicked the button!");
        if (isImgOn == true)
        {
            Dropdown.enabled = false;
            Voedsel.enabled = false;
            Koffie.enabled = false;
            Thee.enabled = false;
            Wijn.enabled = false;
            Zuivel.enabled = false;
            isImgOn = false;
        }

        else
        {
            Dropdown.enabled = true;
            Voedsel.enabled = true;
            Koffie.enabled = true;
            Thee.enabled = true;
            Wijn.enabled = true;
            Zuivel.enabled = true;
            isImgOn = true;
        }
    }
    
}
