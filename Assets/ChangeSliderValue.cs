using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeSliderValue : MonoBehaviour
{
    public Slider slider;
    public GameObject slidertext;
   public void SlideValue()
    {
        Debug.Log(slider.value);
    }
}
