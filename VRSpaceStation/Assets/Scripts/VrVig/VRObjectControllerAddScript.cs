using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class VRObjectControllerAddScript : MonoBehaviour
{
    
    public void AutoAddScript()
    {
        //Add Rigidbody
        if (gameObject.GetComponent<Rigidbody>() == null)
            gameObject.AddComponent<Rigidbody>();

        //Add Fixed Joint between hand and object
        if (gameObject.GetComponent<VRTK.GrabAttachMechanics.VRTK_FixedJointGrabAttach>() == null)
        {
            gameObject.AddComponent<VRTK.GrabAttachMechanics.VRTK_FixedJointGrabAttach>();
            gameObject.GetComponent<VRTK.GrabAttachMechanics.VRTK_FixedJointGrabAttach>().precisionGrab = true;
            gameObject.GetComponent<VRTK.GrabAttachMechanics.VRTK_FixedJointGrabAttach>().breakForce = 10000;
        }

       
        //Add Intractable scripts
        if (gameObject.GetComponent<VRTK.VRTK_InteractableObject>() == null)
        {
            gameObject.AddComponent<VRTK.VRTK_InteractableObject>();
            gameObject.GetComponent<VRTK.VRTK_InteractableObject>().isGrabbable = true;
            gameObject.GetComponent<VRTK.VRTK_InteractableObject>().grabOverrideButton = VRTK.VRTK_ControllerEvents.ButtonAlias.TriggerPress;
            gameObject.GetComponent<VRTK.VRTK_InteractableObject>().grabAttachMechanicScript = gameObject.GetComponent<VRTK.GrabAttachMechanics.VRTK_FixedJointGrabAttach>();
            gameObject.GetComponent<VRTK.VRTK_InteractableObject>().isUsable = true;
        }

        //Add InteractControllApperance script
        if (gameObject.GetComponent<VRTK.VRTK_InteractControllerAppearance>() == null)
            gameObject.AddComponent<VRTK.VRTK_InteractControllerAppearance>();

        //Don't know if this is needed.
        if (gameObject.GetComponent<VRTK.SecondaryControllerGrabActions.VRTK_SwapControllerGrabAction>() == null)
            gameObject.AddComponent<VRTK.SecondaryControllerGrabActions.VRTK_SwapControllerGrabAction>();
    }

    public void RemoveAll()
    {
        // To remove all to update.
        DestroyImmediate(GetComponent<Rigidbody>());
        DestroyImmediate(GetComponent<VRTK.GrabAttachMechanics.VRTK_FixedJointGrabAttach>());
        DestroyImmediate(GetComponent<VRTK.VRTK_InteractableObject>());
        DestroyImmediate(GetComponent<VRTK.VRTK_InteractControllerAppearance>());
        DestroyImmediate(GetComponent<VRTK.SecondaryControllerGrabActions.VRTK_SwapControllerGrabAction>());
    }


}
