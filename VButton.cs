using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VButton : MonoBehaviour, IVirtualButtonEventHandler
{
    VirtualButtonBehaviour[] virtualBtnBehaviours;
    //public GameObject warning
    // Start is called before the first frame update
    void Start()
    {
        virtualBtnBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();

        for (int i = 0; i < virtualBtnBehaviours.Length; ++i)
        {
            virtualBtnBehaviours[i].RegisterEventHandler(this);
        }
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb){
        Debug.Log("OnButtonPressed: " + vb.VirtualButtonName);
        GetComponentInChildren<Animator>().SetBool("isAtteck", true);
        //warning.SetActive(true);
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonReleased: " + vb.VirtualButtonName);
        GetComponentInChildren<Animator>().SetBool("isAtteck", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
