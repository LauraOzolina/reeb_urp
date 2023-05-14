using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MovementValues : MonoBehaviour
{
    public float height,longitudinal,lateral,patient_long,patient_lat;
    public LoadSavedValues TaskInfo;
    // Start is called before the first frame update
    void Start()
    {
        height = 0f;
        longitudinal = 0f;
        lateral = 0f;
        patient_long = 0f;
        patient_lat = 0f;
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
                        &&(Mathf.Approximately((float)System.Math.Round(longitudinal, 2), PlayerPrefs.GetFloat("t1_treatment_x", 0f))))
                    {
                        Debug.Log("Bed arranged");
                        TaskInfo.step_1 = 3;
                        TaskInfo.status_msg[1] = "Status: Bed position set. Patient position can be set.";
                        TaskInfo.statustext.GetComponent<TMP_Text>().text = TaskInfo.status_msg[1];
                    }
                    
            
                }


            break;

            case 2:

                break;

            case 3:

                break;
        }
    }
}
