using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ProductieHandler : MonoBehaviour
{
    public Button m_YourFirstButton;
    public bool isImgOn;
    public Image Dropdown;
    public Text Hoogovens;
    public Text Instrumenten;
    public Text WapensFabriek;

    void Start()
    {
        Button btn1 = m_YourFirstButton.GetComponent<Button>();

        //Calls the TaskOnClick/TaskWithParameters method when you click the Button
        btn1.onClick.AddListener(TaskOnClick);

        Dropdown.enabled = false;
        Hoogovens.enabled = false;
        Instrumenten.enabled = false;
        WapensFabriek.enabled = false;
        isImgOn = false;
    }

    void TaskOnClick()
    {
        //Output this to console when the Button is clicked
        Debug.Log("You have clicked the button!");
        if (isImgOn == true)
        {
            Dropdown.enabled = false;
            Hoogovens.enabled = false;
            Instrumenten.enabled = false;
            WapensFabriek.enabled = false;
            isImgOn = false;
        }

        else
        {
            Dropdown.enabled = true;
            Hoogovens.enabled = true;
            Instrumenten.enabled = true;
            WapensFabriek.enabled = true;
            isImgOn = true;
        }
    }
    
}
