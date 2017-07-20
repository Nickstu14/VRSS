using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VrHandInteraction : MonoBehaviour {
    public VRTK.VRTK_ControllerEvents m_handEvent;
    public bool m_Trigger;

    // Use this for initialization
    void Start () {
        m_handEvent = GetComponent<VRTK.VRTK_ControllerEvents>();

        if (m_handEvent == null)
        {print("No Hand Events found");
            VRTK.VRTK_Logger.Error(VRTK.VRTK_Logger.GetCommonMessage(VRTK.VRTK_Logger.CommonMessageKeys.REQUIRED_COMPONENT_MISSING_FROM_GAMEOBJECT, "VRTK_ControllerEvents_ListenerExample", "VRTK_ControllerEvents", "the same"));
            
            return;
        }
        //m_handEvent.TriggerPressed += new VRTK.ControllerInteractionEventHandler(DoTriggerPressed);
       // m_handEvent.TriggerReleased += new VRTK.ControllerInteractionEventHandler(DoTriggerReleased);
        m_handEvent.TriggerClicked += new VRTK.ControllerInteractionEventHandler(DoTriggerClicked);
        m_handEvent.TriggerUnclicked += new VRTK.ControllerInteractionEventHandler(DoTriggerUnclicked);

        m_Trigger = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    /*private void DoTriggerPressed(object sender, VRTK.ControllerInteractionEventArgs e)
    {
        m_Trigger = true;
        print(m_Trigger);
    }

    private void DoTriggerReleased(object sender, VRTK.ControllerInteractionEventArgs e)
    {
        m_Trigger = false;
        print(m_Trigger);
    }*/
    private void DoTriggerClicked(object sender, VRTK.ControllerInteractionEventArgs e)
    {
        m_Trigger = true;
        
    }
    private void DoTriggerUnclicked(object sender, VRTK.ControllerInteractionEventArgs e)
    {
        m_Trigger = false;
        
    }

    void OnTriggerStay(Collider _col)
    {
        print("collided");
        if (_col.tag == "PurchasePod")
        {
            print("ControllerEnter");
        }
    }
}
