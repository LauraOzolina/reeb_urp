using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeTreatmentValues : MonoBehaviour
{
    public GameObject value;
    public string prefname;
    int val;
    public void PlusOne()
    {
        val = int.Parse(value.GetComponent<TMP_Text>().text);
        if (val < 3)
        {
            val += 1;
            PlayerPrefs.SetInt(prefname, val);
        }
        value.GetComponent<TMP_Text>().text = val.ToString();
    }

    public void MinusOne()
    {
        
        val = int.Parse(value.GetComponent<TMP_Text>().text);
        if(val > 0)
        {
            val -= 1;
            PlayerPrefs.SetInt(prefname, val);
        }
       
        value.GetComponent<TMP_Text>().text = val.ToString();
    }
}
