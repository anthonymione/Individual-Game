using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus;
using UnityEngine.UI;

public class SlowMotion : MonoBehaviour
{
    private float slowMo = 0.1f;
    private float normTime = 1.0f;
    private bool doSlowMo = false;
    //private bool isMoving = false;

    [SerializeField] private OVRPlayerController player;
    //[SerializeField] private Text textUI;

    void Update()
    {
        //bool move = Moving();

        if (player.mController.velocity.magnitude > 0)
        {
            if (doSlowMo)
            {
                Time.timeScale = normTime;
                Time.fixedDeltaTime = 0.02f * Time.timeScale;
                //textUI.text = Time.timeScale.ToString("0");
                doSlowMo = false;
            }   
        }
        else
        {
            if (!doSlowMo)
            {
                Time.timeScale = slowMo;
                Time.fixedDeltaTime = 0.02f * Time.timeScale;
                //textUI.text = Time.timeScale.ToString("0");
                doSlowMo = true;
            }
        }
    }

    /*
    public bool Moving()
    {
        //bool isMoving = false;
        if (OVRInput.Get(OVRInput.Button.DpadUp))
        {
            
            isMoving = true;

        }

        if (OVRInput.Get(OVRInput.Button.DpadDown))
        {
            
            isMoving = true;
        }
        return isMoving;
    }
    */
}
