using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class IndustrieHandler : MonoBehaviour
{
    public Button m_YourFirstButton;
    public bool isImgOn;
    public Image Dropdown;
    public Text Grondstoffen;
    public Text Hout;
    public Text Goud;
    public Text Energie;
    public Text Papier;
    public Text Gas;

    void Start()
    {
        Button btn1 = m_YourFirstButton.GetComponent<Button>();

        //Calls the TaskOnClick/TaskWithParameters method when you click the Button
        btn1.onClick.AddListener(TaskOnClick);

        Dropdown.enabled = false;
        Grondstoffen.enabled = false;
        Hout.enabled = false;
        Goud.enabled = false;
        Energie.enabled = false;
        Papier.enabled = false;
        Gas.enabled = false;
        isImgOn = false;
    }

    void TaskOnClick()
    {
        //Output this to console when the Button is clicked
        Debug.Log("You have clicked the button!");
        if (isImgOn == true)
        {
            Dropdown.enabled = false;
            Grondstoffen.enabled = false;
            Hout.enabled = false;
            Goud.enabled = false;
            Energie.enabled = false;
            Papier.enabled = false;
            Gas.enabled = false;
            isImgOn = false;
        }

        else
        {
            Dropdown.enabled = true;
            Grondstoffen.enabled = true;
            Hout.enabled = true;
            Goud.enabled = true;
            Energie.enabled = true;
            Papier.enabled = true;
            Gas.enabled = true;
            isImgOn = true;
        }
    }
    
}
