using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(VRObjectControllerAddScript))]
public class VRObjectControllerAddScriptEditor : Editor
{

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        VRObjectControllerAddScript m_VrController = (VRObjectControllerAddScript)target;

        if (GUILayout.Button("AutoAdd"))
            m_VrController.AutoAddScript();
        if (GUILayout.Button("Remove"))
            m_VrController.RemoveAll();


       

    }
}
