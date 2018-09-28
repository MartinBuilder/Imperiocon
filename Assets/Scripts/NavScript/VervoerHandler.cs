using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class VervoerHandler : MonoBehaviour
{
    public Button m_YourFirstButton;
    public bool isImgOn;
    public Image Dropdown;
    public Text Vervoer;
    public Text Scheepsbouw;
    public Text Autos;
    public Text Vliegtuigen;

    void Start()
    {
        Button btn1 = m_YourFirstButton.GetComponent<Button>();

        //Calls the TaskOnClick/TaskWithParameters method when you click the Button
        btn1.onClick.AddListener(TaskOnClick);

        Dropdown.enabled = false;
        Vervoer.enabled = false;
        Scheepsbouw.enabled = false;
        Autos.enabled = false;
        Vliegtuigen.enabled = false;
        isImgOn = false;
    }

    void TaskOnClick()
    {
        //Output this to console when the Button is clicked
        Debug.Log("You have clicked the button!");
        if (isImgOn == true)
        {
            Dropdown.enabled = false;
            Vervoer.enabled = false;
            Scheepsbouw.enabled = false;
            Autos.enabled = false;
            Vliegtuigen.enabled = false;
            isImgOn = false;
        }

        else
        {
            Dropdown.enabled = true;
            Vervoer.enabled = true;
            Scheepsbouw.enabled = true;
            Autos.enabled = true;
            Vliegtuigen.enabled = true;
            isImgOn = true;
        }
    }
    
}
