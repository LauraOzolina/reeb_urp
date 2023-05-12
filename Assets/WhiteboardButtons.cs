using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteboardButtons : MonoBehaviour
{
    public GameObject taskview;
    public GameObject settingsview;
    void Start()
    {
        settingsview.SetActive(false);
    }
    public void Task1()
    {
        Debug.Log("task1");
    }
    public void Task2()
    {
        Debug.Log("task2");
    }
    public void Task3()
    {
        Debug.Log("task3");
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
