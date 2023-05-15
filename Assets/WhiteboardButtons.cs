using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
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

        txt = "Treatment (left limb) :  X: " + TaskInfo.t1_treat_x.GetComponent<TMP_Text>().text + Environment.NewLine +
        " Y: " + TaskInfo.t1_treat_y.GetComponent<TMP_Text>().text + Environment.NewLine +
        " Z: " + TaskInfo.t1_treat_z.GetComponent<TMP_Text>().text + Environment.NewLine +
        " BedRot: " + TaskInfo.t1_bedrot.GetComponent<TMP_Text>().text + Environment.NewLine +
        " Patient X: " + TaskInfo.t1_pat_x.GetComponent<TMP_Text>().text + Environment.NewLine +
        " Patient Z: " + TaskInfo.t1_pat_z.GetComponent<TMP_Text>().text + Environment.NewLine +
        " Treatment rotation: " + TaskInfo.t1_scanrot.GetComponent<TMP_Text>().text + Environment.NewLine;
        treatmentcard.GetComponent<TMP_Text>().text = txt;
    }
    public void Task2()
    {
        Debug.Log("task2");
        btn1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        btn2.GetComponent<Image>().color = new Color32(93, 195, 138, 255);
        btn3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        TaskInfo.statustext.GetComponent<TMP_Text>().text = TaskInfo.status_msg[2];
        txt = "Treatment (right breast) :  X: " + TaskInfo.t2_treat_x.GetComponent<TMP_Text>().text + Environment.NewLine +
        " Y: " + TaskInfo.t2_treat_y.GetComponent<TMP_Text>().text + Environment.NewLine +
        " Z: " + TaskInfo.t2_treat_z.GetComponent<TMP_Text>().text + Environment.NewLine +
        " BedRot: " + TaskInfo.t2_bedrot.GetComponent<TMP_Text>().text + Environment.NewLine +
        " Patient X: " + TaskInfo.t2_pat_x.GetComponent<TMP_Text>().text + Environment.NewLine +
        " Patient Z: " + TaskInfo.t2_pat_z.GetComponent<TMP_Text>().text + Environment.NewLine +
        " Treatment rotation: " + TaskInfo.t2_scanrot.GetComponent<TMP_Text>().text + Environment.NewLine;
        treatmentcard.GetComponent<TMP_Text>().text = txt;
    }
    public void Task3()
    {
        Debug.Log("task3");
        btn1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        btn2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        btn3.GetComponent<Image>().color = new Color32(93, 195, 138, 255);
        TaskInfo.statustext.GetComponent<TMP_Text>().text = TaskInfo.status_msg[3];
        txt = "Treatment (...) :  X: " + TaskInfo.t3_treat_x.GetComponent<TMP_Text>().text + Environment.NewLine +
            " Y: " + TaskInfo.t3_treat_y.GetComponent<TMP_Text>().text + Environment.NewLine +
            " Z: " + TaskInfo.t3_treat_z.GetComponent<TMP_Text>().text + Environment.NewLine +
            " BedRot: " + TaskInfo.t3_bedrot.GetComponent<TMP_Text>().text + Environment.NewLine +
            " Patient X: " + TaskInfo.t3_pat_x.GetComponent<TMP_Text>().text + Environment.NewLine +
            " Patient Z: " + TaskInfo.t3_pat_z.GetComponent<TMP_Text>().text + Environment.NewLine +
            " Treatment rotation: " + TaskInfo.t3_scanrot.GetComponent<TMP_Text>().text + Environment.NewLine;
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

    public void ResetTasks()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
