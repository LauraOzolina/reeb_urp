using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

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
    // Start is called before the first frame update
    void Start()
    {
        t1_treat_x.GetComponent<TMP_Text>().text = PlayerPrefs.GetInt("t1_treatment_x", 0).ToString();
        t1_treat_y.GetComponent<TMP_Text>().text = PlayerPrefs.GetInt("t1_treatment_y", 0).ToString();
        t1_treat_z.GetComponent<TMP_Text>().text = PlayerPrefs.GetInt("t1_treatment_z", 0).ToString();

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
