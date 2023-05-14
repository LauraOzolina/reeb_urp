using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TattooDetect : MonoBehaviour
{
    public Material wrong;
    public Material correct;
    public LoadSavedValues TaskInfo;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "laser")
        {
            TaskInfo.tattoos_aligned += 1;
            this.gameObject.GetComponent<MeshRenderer>().material = correct;
            //patient/bed is positioned on lasers

        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "laser")
        {
            if(TaskInfo.tattoos_aligned > 0)
            {
                TaskInfo.tattoos_aligned -= 1;
            }
            
            this.gameObject.GetComponent<MeshRenderer>().material = wrong;
        }
    }

}
