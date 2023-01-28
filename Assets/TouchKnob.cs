using Microsoft.MixedReality.Toolkit.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchKnob : MonoBehaviour
{
    public GameObject elekta;
    private Animator anim;
    float prevSpeed;
    int animationState;
    public GameObject raiseable;
    public GameObject bedpush,movable,scanner;
    AnimatorClipInfo[] m_CurrentClipInfo;
    private bool is_Raising,is_Lowering,is_Scanning, is_Moving_out, is_Moving_in = false;
    private int direction;
    void Start()
    {
         anim = elekta.GetComponent<Animator>();
         prevSpeed = anim.speed;
         raiseable = GameObject.FindWithTag("raiseable");
        bedpush = GameObject.FindWithTag("bedpush");
        movable = GameObject.FindWithTag("movable");
        scanner = GameObject.FindWithTag("scanner");
        direction = 2;
    }
    void Update()
    {
        if (is_Raising)
        {
            Debug.Log("its raising");
  
            Vector3 prevpos = raiseable.transform.localPosition;
            if(raiseable.transform.localPosition.y <= 0.52f)
            {
                raiseable.transform.localPosition = new Vector3(prevpos.x, (prevpos.y + 0.001f), prevpos.z);
                Vector3 prevsize = bedpush.transform.localScale;
                bedpush.transform.localScale = new Vector3(prevsize.x, (prevsize.y + 0.0024f), prevsize.z);
                float dif = raiseable.transform.localPosition.y - bedpush.transform.localScale.y;
                Debug.Log("dif" + dif);
            }

          
        }
        if (is_Lowering)
        {
            Debug.Log("its lowering");

            Vector3 prevpos = raiseable.transform.localPosition;
            if (raiseable.transform.localPosition.y >= 0.446f)
            {
                raiseable.transform.localPosition = new Vector3(prevpos.x, (prevpos.y - 0.001f), prevpos.z);
                Vector3 prevsize = bedpush.transform.localScale;
                bedpush.transform.localScale = new Vector3(prevsize.x, (prevsize.y - 0.0024f), prevsize.z);
            }
   

        }
        if (is_Moving_in)
        {
            Debug.Log("its moving in");

            Vector3 prevpos = movable.transform.localPosition;
            movable.transform.localPosition = new Vector3((prevpos.x + 0.001f), prevpos.y, prevpos.z);

        }
        if (is_Moving_out)
        {
            Debug.Log("its moving out");

            Vector3 prevpos = movable.transform.localPosition;
            movable.transform.localPosition = new Vector3((prevpos.x - 0.001f), prevpos.y, prevpos.z);

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
        anim.speed = 0.03f;
        anim.Play("Scanner_Rotating");
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
        //anim.speed = 0;
        Debug.Log("stopmoving");
    }

}
