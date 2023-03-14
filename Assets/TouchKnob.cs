using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class TouchKnob : MonoBehaviour
{
    public GameObject elekta;
    private Animator anim;
    float prevSpeed;
    int animationState;
    public GameObject raiseable;
    public GameObject bedpush,movable,scanner,bedbase;
    AnimatorClipInfo[] m_CurrentClipInfo;
    private bool is_Raising,is_Lowering,is_Scanning, is_Moving_out, is_Moving_in, is_Bed_Rotate_Left, is_Bed_Rotate_Right, is_Laser_Off,is_Lat_Left,is_Lat_Right = false;
    private int direction;
    public MovementValues mvalues;
    public GameObject heighttmp;
    public GameObject longitudinaltmp;
    void Start()
    {

        anim = elekta.GetComponent<Animator>();
        prevSpeed = anim.speed;
        raiseable = GameObject.FindWithTag("raiseable");
        bedpush = GameObject.FindWithTag("bedpush");
        movable = GameObject.FindWithTag("movable");
        scanner = GameObject.FindWithTag("scanner");
        bedbase = GameObject.FindWithTag("bedbaserot");
        heighttmp = GameObject.FindWithTag("heighttmp");
        longitudinaltmp = GameObject.FindWithTag("longitudinaltmp");
        direction = 2;
     
    }
    void Update()
    {
        if (is_Raising)
        {
            Debug.Log("its raising");
  
            Vector3 prevpos = raiseable.transform.localPosition;
            if(raiseable.transform.localPosition.y < 0.66f)
            {
                raiseable.transform.localPosition = new Vector3(prevpos.x, (prevpos.y + 0.001f), prevpos.z);
                Vector3 prevsize = bedpush.transform.localScale;
                bedpush.transform.localScale = new Vector3(prevsize.x, (prevsize.y + 0.0033f), prevsize.z);
                float dif = raiseable.transform.localPosition.y - bedpush.transform.localScale.y;
                mvalues.height = mvalues.height + 0.001f;
                heighttmp.GetComponent<TMP_Text>().text = "Height: " + System.Math.Round(mvalues.height, 2);



            }


        }
        if (is_Lowering)
        {
            Debug.Log("its lowering");

            Vector3 prevpos = raiseable.transform.localPosition;
            if (raiseable.transform.localPosition.y > 0.452f)
            {
                raiseable.transform.localPosition = new Vector3(prevpos.x, (prevpos.y - 0.001f), prevpos.z);
                Vector3 prevsize = bedpush.transform.localScale;
                bedpush.transform.localScale = new Vector3(prevsize.x, (prevsize.y - 0.0033f), prevsize.z);
                mvalues.height = mvalues.height - 0.001f;
                heighttmp.GetComponent<TMP_Text>().text = "Height: " + System.Math.Round(mvalues.height,2);
            }
   

        }
        if (is_Moving_in)
        {
            Debug.Log("its moving in");

            Vector3 prevpos = movable.transform.localPosition;
            movable.transform.localPosition = new Vector3((prevpos.x + 0.001f), prevpos.y, prevpos.z);
            mvalues.longitudinal = mvalues.longitudinal + 0.001f;
            longitudinaltmp.GetComponent<TMP_Text>().text = "Long: " + System.Math.Round(mvalues.longitudinal, 2);
        }
        if (is_Moving_out)
        {
            Debug.Log("its moving out");

            Vector3 prevpos = movable.transform.localPosition;
            movable.transform.localPosition = new Vector3((prevpos.x - 0.001f), prevpos.y, prevpos.z);
            mvalues.longitudinal = mvalues.longitudinal - 0.001f;
            longitudinaltmp.GetComponent<TMP_Text>().text = "Long: " + System.Math.Round(mvalues.longitudinal, 2);
        }
        if (is_Bed_Rotate_Left)
        {
          
                Vector3 rotationVector = bedbase.transform.eulerAngles;
                Debug.Log(rotationVector);
                bedbase.transform.eulerAngles = new Vector3(rotationVector.x, (rotationVector.y + 0.1f), rotationVector.z);
            
        }

        if (is_Bed_Rotate_Right)
        {
           
                Vector3 rotationVector = bedbase.transform.eulerAngles;
                Debug.Log(rotationVector);
                bedbase.transform.eulerAngles = new Vector3(rotationVector.x, (rotationVector.y - 0.1f), rotationVector.z);
            
        }

        if (is_Lat_Left)
        {

         
            Vector3 prevpos = raiseable.transform.localPosition;
            if (raiseable.transform.localPosition.z < 0.1f)
            {
                raiseable.transform.localPosition = new Vector3(prevpos.x, prevpos.y, (prevpos.z + 0.001f));
      
            }

        }
        if (is_Lat_Right)
        {


            Vector3 prevpos = raiseable.transform.localPosition;
            if (raiseable.transform.localPosition.z > -0.1f)
            {
                raiseable.transform.localPosition = new Vector3(prevpos.x, prevpos.y, (prevpos.z - 0.001f));

            }

        }

    }
    public void Raise_Bed()
    {
        is_Raising = true;

        //anim.speed = prevSpeed;
        //anim.SetFloat("direction", 1);
        //anim.Play("Bed_Raising");
        Debug.Log("touch");
       
    }

    public void Stop_Raise_Bed()
    {
        is_Raising = false;
        is_Lowering = false;
        //anim.speed = 0;
        //m_CurrentClipInfo = anim.GetCurrentAnimatorClipInfo(0);
        //Debug.Log(m_CurrentClipInfo[0].clip.name);
        Debug.Log("stop");
    }

    public void Lower_Bed()
    {
        is_Lowering = true;
        //anim.speed = prevSpeed;
        //anim.SetFloat("direction", -1);
        //anim.Play("Bed_Raising");
        Debug.Log("lower");
    }

    public void Rotate_Scanner()
    {
        is_Scanning = true;
        anim.speed = 0.01f;
        anim.Play("linac_scan");
        Debug.Log("rotate");
    }

    public void Move_Bed_Inwards()
    {
        is_Moving_in = true;
        //anim.speed = prevSpeed;
        //anim.SetFloat("direction", 1);
        //anim.Play("Bed_Moving");
        Debug.Log("moving_in");
    }

    public void Move_Bed_Outwards()
    {
        is_Moving_out = true;
        //anim.speed = prevSpeed;
        //anim.SetFloat("direction", -1);
        //anim.Play("Bed_Moving");
        Debug.Log("moving_out");
    }

    public void Stop_Moving_Bed()
    {
        is_Moving_out = false;
        is_Moving_in = false;
        is_Lat_Left = false;
        is_Lat_Right = false;
        //anim.speed = 0;
        Debug.Log("stopmoving");
    }

    public void Rotate_Bed_Left()
    {
        is_Bed_Rotate_Left = true;

        Debug.Log("bed_rotate");

    }
    public void Rotate_Bed_Right()
    {
        is_Bed_Rotate_Right = true;

        Debug.Log("bed_rotate");

    }

    public void Stop_Rotate_Bed()
    {
        is_Bed_Rotate_Left = false;
        is_Bed_Rotate_Right = false;

        Debug.Log("stop_bed_rotate");

    }

    public void Bed_Lat_Left()
    {
        is_Lat_Left = true;
        Debug.Log("lat_left");

    }
    public void Bed_Lat_Right()
    {
        is_Lat_Right = true;
        Debug.Log("lat_right");

    }

    public void Toggle_Laser()
    {
        GameObject[] lasers = GameObject.FindGameObjectsWithTag("laser");
        Debug.Log(is_Laser_Off);
        if (is_Laser_Off == true)
        {
            foreach (GameObject la in lasers)
            {
                Debug.Log(la);
       
                la.GetComponent<DecalProjector>().enabled = true;
            }
            is_Laser_Off = false;
        }
        else
        {
            foreach (GameObject la in lasers)
            {
                Debug.Log(la);
                la.GetComponent<DecalProjector>().enabled = false;
            }
            is_Laser_Off = true;
            
        }
  
        Debug.Log("laser");

    }

    public void Toggle_Movable()
    {
        if (elekta.GetComponent<ObjectManipulator>().enabled)
        {
            elekta.GetComponent<ObjectManipulator>().enabled = false;
        }
        else
        {
            elekta.GetComponent<ObjectManipulator>().enabled = true;
        }
    }

}
