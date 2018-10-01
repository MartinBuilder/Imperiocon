using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MainBtnOpdrachten : MonoBehaviour {

    public Button m_YourFirstButton;
    public bool isImgOn;
    public Image ImageMain;
    public Text Title;
    public Text Main;
    public Button Voltooi;


    void Start()
    {
        Button btn1 = m_YourFirstButton.GetComponent<Button>();

        //Calls the TaskOnClick/TaskWithParameters method when you click the Button
        btn1.onClick.AddListener(TaskOnClick);

        ImageMain.enabled = false;
        Title.enabled = false;
        Main.enabled = false;
        isImgOn = false;
        Voltooi.enabled = false;
    }

    void TaskOnClick()
    {
        //Output this to console when the Button is clicked
        Debug.Log("You have clicked the button!");
        if (isImgOn == true)
        {
            ImageMain.enabled = false;
            Title.enabled = false;
            Main.enabled = false;
            isImgOn = false;
            Voltooi.enabled = false;
        }

        else
        {
            ImageMain.enabled = true;
            Title.enabled = true;
            Main.enabled = true;
            isImgOn = true;
            Voltooi.enabled = true;
        }
    }

    void Update ()
    {
        if(Voltooi.enabled == false)
        {
            Debug.Log("gallo");
        }
        if(Voltooi.enabled == true)
        {
            Debug.Log("WTAF");
        }
    }
}
