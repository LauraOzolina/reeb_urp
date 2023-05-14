using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChangeTreatmentValues : MonoBehaviour
{
    public GameObject value;
    public string prefname;
    float val;
    bool ispressed = false;
    public int btnwhich;

    public void PlusOne()
    {
        val = float.Parse(value.GetComponent<TMP_Text>().text);
     
        val += 0.5f;
        PlayerPrefs.SetFloat(prefname, val);
       
        value.GetComponent<TMP_Text>().text = val.ToString();
    }

    public void MinusOne()
    {
        
        val = float.Parse(value.GetComponent<TMP_Text>().text);
  
        val -= 0.5f;
        PlayerPrefs.SetFloat(prefname, val);
        
       
        value.GetComponent<TMP_Text>().text = val.ToString();
    }


}
