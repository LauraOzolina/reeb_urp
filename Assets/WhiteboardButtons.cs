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


        txt = "Treatment (left limb) :  X: " + PlayerPrefs.GetInt("t1_treatment_x", 0).ToString() + " Y: "
        + PlayerPrefs.GetInt("t1_treatment_y", 0).ToString() + " Z: " + PlayerPrefs.GetInt("t1_treatment_z", 0).ToString();
        treatmentcard.GetComponent<TMP_Text>().text = txt;
    }
    public void Task2()
    {
        Debug.Log("task2");
        btn1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        btn2.GetComponent<Image>().color = new Color32(93, 195, 138, 255);
        btn3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);

        txt = "Treatment (left limb) :  X: " + PlayerPrefs.GetInt("t2_treatment_x", 0).ToString() + " Y: "
        + PlayerPrefs.GetInt("t2_treatment_y", 0).ToString() + " Z: " + PlayerPrefs.GetInt("t2_treatment_z", 0).ToString();
        treatmentcard.GetComponent<TMP_Text>().text = txt;
    }
    public void Task3()
    {
        Debug.Log("task3");
        btn1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        btn2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        btn3.GetComponent<Image>().color = new Color32(93, 195, 138, 255);

        txt = "Treatment (left limb) :  X: " + PlayerPrefs.GetInt("t3_treatment_x", 0).ToString() + " Y: "
        + PlayerPrefs.GetInt("t3_treatment_y", 0).ToString() + " Z: " + PlayerPrefs.GetInt("t3_treatment_z", 0).ToString();
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
