using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Module
{
    [CustomEditor(typeof(AutoModuleAdd))]
    public class AutoModuleAddEditor : Editor
    {

        private int m_O2;
        private int m_Pop;
        // private bool m_Power;

        private GUIStyle m_style;
        private GUIContent m_GuiContent;

        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            AutoModuleAdd m_ModuleAdd = (AutoModuleAdd)target;

            
           // m_style.fontStyle = FontStyle.Bold;
           // m_style.alignment = TextAnchor.MiddleCenter;
            GUILayout.Label("Additional scripts" );

            m_ModuleAdd.m_LifeSupport = GUILayout.Toggle(m_ModuleAdd.m_LifeSupport, "LifeSupport");
            if (m_ModuleAdd.m_LifeSupport)
            {
                // m_ModuleAdd.SetPopulation(EditorGUILayout.IntField("Max Population", m_Pop));
                // m_ModuleAdd.SetO2(EditorGUILayout.IntField("Max Oxygen Level",m_O2));
                m_ModuleAdd.m_MaxO2 = m_O2;
            }

            if (GUILayout.Button("AutoAdd"))
                m_ModuleAdd.AutoAddModuleScripts();


        }
    }
}