using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TattooDetect : MonoBehaviour
{
    public Material wrong;
    public Material correct;
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "laser")
        {
            Debug.Log("piupiu");
            this.gameObject.GetComponent<MeshRenderer>().material = correct;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "laser")
        {
            Debug.Log("piupiu");
            this.gameObject.GetComponent<MeshRenderer>().material = wrong;
        }
    }

}
