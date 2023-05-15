using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MovementValues : MonoBehaviour
{
    public float height,longitudinal,lateral,patient_long,patient_lat, treatmentrot, bedrot;
    public LoadSavedValues TaskInfo;
    public AudioSource source;
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        height = 0f;
        longitudinal = 0f;
        lateral = 0f;
        patient_long = 0f;
        patient_lat = 0f;
        treatmentrot = 0f;
        bedrot = 0f;
    }

    // Update is called once per frame
    void Update()
    {
  
        switch (TaskInfo.activetask)
        {
            case 1:
                if(TaskInfo.step_1 == 2)
                {
                   
                    if((Mathf.Approximately((float)System.Math.Round(height, 2), PlayerPrefs.GetFloat("t1_treatment_y", 0f)))
                        &&(Mathf.Approximately((float)System.Math.Round(longitudinal, 2), PlayerPrefs.GetFloat("t1_treatment_x", 0f)))
                        && (Mathf.Approximately((float)System.Math.Round(lateral, 2), PlayerPrefs.GetFloat("t1_treatment_z", 0f)))
                        && (Mathf.Approximately((float)System.Math.Round(bedrot, 2), PlayerPrefs.GetFloat("t1_bedrot", 0f))))
                    {
                        Debug.Log("Bed arranged");
                        source.PlayOneShot(clip);
                        TaskInfo.step_1 = 3;
                        TaskInfo.status_msg[1] = "Status: Bed position set. Patient position can be set.";
                        TaskInfo.statustext.GetComponent<TMP_Text>().text = TaskInfo.status_msg[1];
                    }
                    
            
                }

                if(TaskInfo.step_1 == 3)
                {
                    if ((Mathf.Approximately((float)System.Math.Round(patient_long, 2), PlayerPrefs.GetFloat("t1_patient_x", 0f)))
                                      && (Mathf.Approximately((float)System.Math.Round(patient_lat, 2), PlayerPrefs.GetFloat("t1_patient_z", 0f))))
                    {
                        Debug.Log("Patient arranged");
                        source.PlayOneShot(clip);
                        TaskInfo.step_1 = 4;
                        TaskInfo.status_msg[1] = "Status: Patient position set. Treatment rotation can be set.";
                        TaskInfo.statustext.GetComponent<TMP_Text>().text = TaskInfo.status_msg[1];
                    }
                }

                if(TaskInfo.step_1 == 4)
                {
                    if ((Mathf.Approximately((float)System.Math.Round(treatmentrot, 2), PlayerPrefs.GetFloat("t1_scanrot", 0f))))
                    {
                        Debug.Log("Treatment arranged");
                        source.PlayOneShot(clip);
                        TaskInfo.step_1 = 5;
                        TaskInfo.status_msg[1] = "Status: Task completed. Correct treatment position.";
                        TaskInfo.statustext.GetComponent<TMP_Text>().text = TaskInfo.status_msg[1];
                    }
                }


            break;

            case 2:
                if (TaskInfo.step_2 == 2)
                {

                    if ((Mathf.Approximately((float)System.Math.Round(height, 2), PlayerPrefs.GetFloat("t2_treatment_y", 0f)))
                        && (Mathf.Approximately((float)System.Math.Round(longitudinal, 2), PlayerPrefs.GetFloat("t2_treatment_x", 0f)))
                        && (Mathf.Approximately((float)System.Math.Round(lateral, 2), PlayerPrefs.GetFloat("t2_treatment_z", 0f)))
                        && (Mathf.Approximately((float)System.Math.Round(bedrot, 2), PlayerPrefs.GetFloat("t2_bedrot", 0f))))
                    {
                        Debug.Log("Bed arranged");
                        TaskInfo.step_2 = 3;
                        TaskInfo.status_msg[2] = "Status: Bed position set. Patient position can be set.";
                        TaskInfo.statustext.GetComponent<TMP_Text>().text = TaskInfo.status_msg[2];
                    }


                }
                break;

            case 3:
                if (TaskInfo.step_3 == 2)
                {

                    if ((Mathf.Approximately((float)System.Math.Round(height, 2), PlayerPrefs.GetFloat("t3_treatment_y", 0f)))
                        && (Mathf.Approximately((float)System.Math.Round(longitudinal, 2), PlayerPrefs.GetFloat("t3_treatment_x", 0f)))
                        && (Mathf.Approximately((float)System.Math.Round(lateral, 2), PlayerPrefs.GetFloat("t3_treatment_z", 0f)))
                        && (Mathf.Approximately((float)System.Math.Round(bedrot, 2), PlayerPrefs.GetFloat("t3_bedrot", 0f))))
                    {
                        Debug.Log("Bed arranged");
                        TaskInfo.step_3 = 3;
                        TaskInfo.status_msg[3] = "Status: Bed position set. Patient position can be set.";
                        TaskInfo.statustext.GetComponent<TMP_Text>().text = TaskInfo.status_msg[3];
                    }


                }
                break;
        }
    }
}
