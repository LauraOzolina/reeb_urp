using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WhiteboardButtons : MonoBehaviour
{
    public GameObject taskview;
    public GameObject settingsview;
    public GameObject btn1;
    public GameObject btn2;
    public GameObject btn3;
    public GameObject treatmentcard;
    public LoadSavedValues TaskInfo;
    public string txt;
    void Start()
    {
        settingsview.SetActive(false);
    }
    public void Task1()
    {
        Debug.Log("task1");
        btn1.GetComponent<Image>().color = new Color32(93, 195, 138, 255);
        btn2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        btn3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
       
        TaskInfo.statustext.GetComponent<TMP_Text>().text = TaskInfo.status_msg[1];

        txt = "Treatment (left limb) :  X: " + PlayerPrefs.GetFloat("t1_treatment_x", 0f).ToString() + " Y: "
        + PlayerPrefs.GetFloat("t1_treatment_y", 0f).ToString() + " Z: " + PlayerPrefs.GetFloat("t1_treatment_z", 0f).ToString();
        treatmentcard.GetComponent<TMP_Text>().text = txt;
    }
    public void Task2()
    {
        Debug.Log("task2");
        btn1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        btn2.GetComponent<Image>().color = new Color32(93, 195, 138, 255);
        btn3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TaskInfo.statustext.GetComponent<TMP_Text>().text = TaskInfo.status_msg[2];
        txt = "Treatment (right breast) :  X: " + PlayerPrefs.GetFloat("t2_treatment_x", 0f).ToString() + " Y: "
        + PlayerPrefs.GetFloat("t2_treatment_y", 0f).ToString() + " Z: " + PlayerPrefs.GetFloat("t2_treatment_z", 0f).ToString();
        treatmentcard.GetComponent<TMP_Text>().text = txt;
    }
    public void Task3()
    {
        Debug.Log("task3");
        btn1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        btn2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        btn3.GetComponent<Image>().color = new Color32(93, 195, 138, 255);
        TaskInfo.statustext.GetComponent<TMP_Text>().text = TaskInfo.status_msg[3];
        txt = "Treatment (...) :  X: " + PlayerPrefs.GetFloat("t3_treatment_x", 0f).ToString() + " Y: "
        + PlayerPrefs.GetFloat("t3_treatment_y", 0f).ToString() + " Z: " + PlayerPrefs.GetFloat("t3_treatment_z", 0f).ToString();
        treatmentcard.GetComponent<TMP_Text>().text = txt;
    }

    public void Settings()
    {
        taskview.SetActive(false);
        settingsview.SetActive(true);
    }

    public void Back()
    {
        taskview.SetActive(true);
        settingsview.SetActive(false);
    }

}
