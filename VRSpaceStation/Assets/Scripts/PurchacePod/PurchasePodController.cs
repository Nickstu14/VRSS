﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 The purchase pod will only need 1 module displayed this will be pre-determend (hard coded) during development.
 This is what it currently is, if this was to change then an update function will need to be added. 
 The abbility to "hot swap" modules are currently implimented into the onEnable function, this will just need to be moved.
     */

namespace PurchasePod
{
    [AddComponentMenu("VRSS/VR/Purchase Pod/Purchase Pod Controller")]
    public class PurchasePodController : MonoBehaviour
    {
        public GameObject m_Module;
        public ModuleObjects.Module m_ModuleNum;
        private GameObject m_TempModule;
        private GameObject m_GO;
        // public List<GameObject> s_Modules;

        public Text m_TimeDisplay; //Display text Not for editing 
        public Text m_CostDisplay; //Display text Not for editing
        public Text m_TitleDisplay; //Display text Not for editing
                                   //Visual changes see P'P'CanvasDisplay
        public string m_ErrorMsg;

        public Material m_DisplayMaterial;

        [Range(0, 20)]
        public float m_ModuleHeight;

        [Range(10, 100)]
        public float m_Spinspeed;

        void OnEnable()
        {
            m_Module = GameObject.Find("ModuleList").GetComponent<ModuleObjects>().DisplayModule(m_ModuleNum);
            if (m_Module != null)
            {
                GetComponent<PurchasePodInstanciateModule>().SetModule(m_Module);
                if (m_GO == null || m_TempModule != m_Module)
                {
                    if (m_GO != null)
                        Destroy(m_GO);
                    SpawnPodModule(m_Module);
                }

                //Changing Material of PP display model
                foreach (Renderer f in m_GO.GetComponentsInChildren<Renderer>())
                    f.material = m_DisplayMaterial;

                if (m_Module.GetComponent<Module.BasicModuleInfo>() != null)
                {
                    m_TimeDisplay.text = m_Module.GetComponent<Module.BasicModuleInfo>().GetTimeString();
                    m_CostDisplay.text = m_Module.GetComponent<Module.BasicModuleInfo>().GetCostString();
                    m_TitleDisplay.text = m_Module.GetComponent<Module.BasicModuleInfo>().GetName();
                }
                else
                {
                    m_TimeDisplay.text = m_ErrorMsg;
                    m_CostDisplay.text = m_ErrorMsg;
                    m_TitleDisplay.text = m_ErrorMsg;
                }
            }
        }

        void SpawnPodModule(GameObject _Module)
        {
            m_TempModule = _Module;
            m_GO = Instantiate(_Module, Position(), Quaternion.identity);
            m_GO.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
            m_GO.AddComponent<PurchacePodModuleSpin>();
            m_GO.transform.parent = transform;
        }

        Vector3 Position()
        {
            Vector3 m_pos = gameObject.transform.position;
            // m_pos.y = gameObject.transform.position.y + m_ModuleHeight;
            m_pos.y = gameObject.transform.position.y + (GetComponent<SphereCollider>().center.y * 0.05f); //centers the game object into the sphere
            return m_pos;
        }

    }
}
