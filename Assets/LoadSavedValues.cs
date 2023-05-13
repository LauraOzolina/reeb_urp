using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

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

    public int activetask;
    public GameObject btn1;
    public GameObject btn2;
    public GameObject btn3;
    public GameObject treatmentcard;
    public string txt;
    // Start is called before the first frame update
    void Start()
    {
        activetask = 1;
        btn1.GetComponent<Image>().color = new Color32(93, 195, 138, 255);
        t1_treat_x.GetComponent<TMP_Text>().text = PlayerPrefs.GetInt("t1_treatment_x", 0).ToString();
        t1_treat_y.GetComponent<TMP_Text>().text = PlayerPrefs.GetInt("t1_treatment_y", 0).ToString();
        t1_treat_z.GetComponent<TMP_Text>().text = PlayerPrefs.GetInt("t1_treatment_z", 0).ToString();

        txt = "Treatment (left limb) :  X: " + t1_treat_x.GetComponent<TMP_Text>().text + " Y: " 
        + t1_treat_y.GetComponent<TMP_Text>().text + " Z: " + t1_treat_z.GetComponent<TMP_Text>().text;
        treatmentcard.GetComponent<TMP_Text>().text = txt;

        t2_treat_x.GetComponent<TMP_Text>().text = PlayerPrefs.GetInt("t2_treatment_x", 0).ToString();
        t2_treat_y.GetComponent<TMP_Text>().text = PlayerPrefs.GetInt("t2_treatment_y", 0).ToString();
        t2_treat_z.GetComponent<TMP_Text>().text = PlayerPrefs.GetInt("t2_treatment_z", 0).ToString();

        t3_treat_x.GetComponent<TMP_Text>().text = PlayerPrefs.GetInt("t3_treatment_x", 0).ToString();
        t3_treat_y.GetComponent<TMP_Text>().text = PlayerPrefs.GetInt("t3_treatment_y", 0).ToString();
        t3_treat_z.GetComponent<TMP_Text>().text = PlayerPrefs.GetInt("t3_treatment_z", 0).ToString();

        t1_pat_x.GetComponent<TMP_Text>().text = PlayerPrefs.GetInt("t1_patient_x", 0).ToString();
        t1_pat_z.GetComponent<TMP_Text>().text = PlayerPrefs.GetInt("t1_patient_z", 0).ToString();

        t2_pat_x.GetComponent<TMP_Text>().text = PlayerPrefs.GetInt("t2_patient_x", 0).ToString();
        t2_pat_z.GetComponent<TMP_Text>().text = PlayerPrefs.GetInt("t2_patient_z", 0).ToString();

        t3_pat_z.GetComponent<TMP_Text>().text = PlayerPrefs.GetInt("t3_patient_x", 0).ToString();
        t3_pat_z.GetComponent<TMP_Text>().text = PlayerPrefs.GetInt("t3_patient_z", 0).ToString();
    }


}
