using Microsoft.MixedReality.Toolkit.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class LoadSavedValues : MonoBehaviour
{
    public GameObject t1_treat_x;
    public GameObject t1_treat_y;
    public GameObject t1_treat_z;
    public GameObject t2_treat_x;
    public GameObject t2_treat_y;
    public GameObject t2_treat_z;
    public GameObject t3_treat_x;
    public GameObject t3_treat_y;
    public GameObject t3_treat_z;
    public GameObject t1_pat_x;

    public GameObject t1_pat_z;
    public GameObject t2_pat_x;

    public GameObject t2_pat_z;
    public GameObject t3_pat_x;

    public GameObject t3_pat_z;
    public GameObject t1_bedrot;
    public GameObject t2_bedrot;
    public GameObject t3_bedrot;
    public GameObject t1_scanrot;
    public GameObject t2_scanrot;
    public GameObject t3_scanrot;
    public int activetask;
    public GameObject btn1;
    public GameObject btn2;
    public GameObject btn3;
    public GameObject treatmentcard;
    public string txt;
    public int step_1;
    public int step_2;
    public int step_3;
    public GameObject statustext;
    public string[] status_msg;
    public int tattoos_aligned;
    public MovementValues mvalues;
    public GameObject[] btn;
    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log(btn.Length);
        activetask = 1;
        step_1 = 1;
        step_2 = 1;
        step_3 = 1;
        status_msg[1] = "Status: Patient is not aligned to laser lines";
        status_msg[2] = "Status: Patient is not aligned to laser lines";
        status_msg[3] = "Status: Patient is not aligned to laser lines";
        btn1.GetComponent<Image>().color = new Color32(93, 195, 138, 255);
        statustext.GetComponent<TMP_Text>().text = status_msg[1];
        t1_treat_x.GetComponent<TMP_Text>().text = PlayerPrefs.GetFloat("t1_treatment_x", 0f).ToString();
        t1_treat_y.GetComponent<TMP_Text>().text = PlayerPrefs.GetFloat("t1_treatment_y", 0f).ToString();
        t1_treat_z.GetComponent<TMP_Text>().text = PlayerPrefs.GetFloat("t1_treatment_z", 0f).ToString();

        txt = "Treatment (left limb) :  X: " + t1_treat_x.GetComponent<TMP_Text>().text + Environment.NewLine + 
            " Y: "+ t1_treat_y.GetComponent<TMP_Text>().text + Environment.NewLine + 
            " Z: " + t1_treat_z.GetComponent<TMP_Text>().text + Environment.NewLine +
            " BedRot: " + t1_bedrot.GetComponent<TMP_Text>().text + Environment.NewLine +
            " Patient X: " + t1_pat_x.GetComponent<TMP_Text>().text + Environment.NewLine +
            " Patient Z: " + t1_pat_z.GetComponent<TMP_Text>().text + Environment.NewLine +
            " Treatment rotation: " + t1_scanrot.GetComponent<TMP_Text>().text + Environment.NewLine;
        treatmentcard.GetComponent<TMP_Text>().text = txt;

        t2_treat_x.GetComponent<TMP_Text>().text = PlayerPrefs.GetFloat("t2_treatment_x", 0f).ToString();
        t2_treat_y.GetComponent<TMP_Text>().text = PlayerPrefs.GetFloat("t2_treatment_y", 0f).ToString();
        t2_treat_z.GetComponent<TMP_Text>().text = PlayerPrefs.GetFloat("t2_treatment_z", 0f).ToString();

        t3_treat_x.GetComponent<TMP_Text>().text = PlayerPrefs.GetFloat("t3_treatment_x", 0f).ToString();
        t3_treat_y.GetComponent<TMP_Text>().text = PlayerPrefs.GetFloat("t3_treatment_y", 0f).ToString();
        t3_treat_z.GetComponent<TMP_Text>().text = PlayerPrefs.GetFloat("t3_treatment_z", 0f).ToString();

        t1_pat_x.GetComponent<TMP_Text>().text = PlayerPrefs.GetFloat("t1_patient_x", 0f).ToString();
        t1_pat_z.GetComponent<TMP_Text>().text = PlayerPrefs.GetFloat("t1_patient_z", 0f).ToString();

        t2_pat_x.GetComponent<TMP_Text>().text = PlayerPrefs.GetFloat("t2_patient_x", 0f).ToString();
        t2_pat_z.GetComponent<TMP_Text>().text = PlayerPrefs.GetFloat("t2_patient_z", 0f).ToString();

        t3_pat_z.GetComponent<TMP_Text>().text = PlayerPrefs.GetFloat("t3_patient_x", 0f).ToString();
        t3_pat_z.GetComponent<TMP_Text>().text = PlayerPrefs.GetFloat("t3_patient_z", 0f).ToString();

        t1_bedrot.GetComponent<TMP_Text>().text = PlayerPrefs.GetFloat("t1_bedrot", 0f).ToString();
        t2_bedrot.GetComponent<TMP_Text>().text = PlayerPrefs.GetFloat("t2_bedrot", 0f).ToString();
        t3_bedrot.GetComponent<TMP_Text>().text = PlayerPrefs.GetFloat("t3_bedrot", 0f).ToString();

        t1_scanrot.GetComponent<TMP_Text>().text = PlayerPrefs.GetFloat("t1_scanrot", 0f).ToString();
        t2_scanrot.GetComponent<TMP_Text>().text = PlayerPrefs.GetFloat("t2_scanrot", 0f).ToString();
        t3_scanrot.GetComponent<TMP_Text>().text = PlayerPrefs.GetFloat("t3_scanrot", 0f).ToString();
    }

    void Update()
    {
        if(tattoos_aligned == 6)
        {
            switch (activetask)
            {
                case 1:
                    if(step_1 == 1)
                    {
                        status_msg[1] = "Status: Patient is aligned. Treatment position can be set.";
                        statustext.GetComponent<TMP_Text>().text = status_msg[1];
                        step_1 = 2;
                        mvalues.source.PlayOneShot(mvalues.clip);
                        DisableButtons();
                       
                    }

                break;

                case 2:
                    if (step_2 == 1)
                    {
                        status_msg[2] = "Status: Patient is aligned. Treatment position can be set.";
                        statustext.GetComponent<TMP_Text>().text = status_msg[2];
                        step_2 = 2;
                        mvalues.source.PlayOneShot(mvalues.clip);
                        DisableButtons();
                    }
                    break;

                case 3:
                    if (step_3 == 1)
                    {
                        status_msg[3] = "Status: Patient is aligned. Treatment position can be set.";
                        statustext.GetComponent<TMP_Text>().text = status_msg[3];
                        step_3 = 2;
                        mvalues.source.PlayOneShot(mvalues.clip);
                        DisableButtons();
                    }
                    break;
            }
        }
    }

    public void DisableButtons()
    {
        for (int i = 0; i < btn.Length; i++)
        {
            // Adding the current 'btn' to the 'buttons' list
            btn[i].GetComponent<PressableButton>().enabled = false;
            btn[i].SetActive(false);
        }
        Invoke("EnableButtons", 1.0f);
    }

    public void EnableButtons()
    {
        for (int i = 0; i < btn.Length; i++)
        {
            // Adding the current 'btn' to the 'buttons' list
            btn[i].GetComponent<PressableButton>().enabled = true;
            btn[i].SetActive(true);
        }
    }


}
