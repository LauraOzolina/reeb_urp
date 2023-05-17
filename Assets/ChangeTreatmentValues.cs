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

    public void PlusFive()
    {
        val = float.Parse(value.GetComponent<TMP_Text>().text);
     
        val += 5.0f;
        PlayerPrefs.SetFloat(prefname, val);
       
        value.GetComponent<TMP_Text>().text = val.ToString();
    }

    public void MinusFive()
    {
        
        val = float.Parse(value.GetComponent<TMP_Text>().text);
  
        val -= 5.0f;
        PlayerPrefs.SetFloat(prefname, val);
        
       
        value.GetComponent<TMP_Text>().text = val.ToString();
    }

    public void PlusZeroFive()
    {
        val = float.Parse(value.GetComponent<TMP_Text>().text);

        val += 0.05f;
        PlayerPrefs.SetFloat(prefname, val);

        value.GetComponent<TMP_Text>().text = val.ToString();
    }

    public void MinusZeroFive()
    {

        val = float.Parse(value.GetComponent<TMP_Text>().text);

        val -= 0.05f;
        PlayerPrefs.SetFloat(prefname, val);


        value.GetComponent<TMP_Text>().text = val.ToString();
    }


}
