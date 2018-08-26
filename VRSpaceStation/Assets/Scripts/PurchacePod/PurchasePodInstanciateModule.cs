﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PurchasePod
{
    [AddComponentMenu("VRSS/VR/Purchase Pod/PurchasePodInstanciateModule")]
    public class PurchasePodInstanciateModule : MonoBehaviour
    {
        public GameObject m_DisplayModule;
        public GameObject m_Module;
        public bool m_SpawnModule = false;

        // Use this for initialization
        void Start()
        {
            m_DisplayModule = GetComponent<PurchasePodController>().m_Module;
            // gameObject.tag = "PurchasePod";
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void SetModule(GameObject _Module)
        {
            m_DisplayModule = _Module;
        }

        void OnTriggerStay(Collider _col)
        {
            if (_col.GetComponent<VrHandInteraction>() != null)
            {
                if (!m_SpawnModule)
                {
                    m_DisplayModule.SetActive(false); //turn off the display module            

                    m_Module = Instantiate(m_DisplayModule, m_DisplayModule.transform.position, Quaternion.identity);
                    m_Module.transform.localScale = m_DisplayModule.transform.localScale;
                    foreach (Renderer f in m_Module.GetComponentsInChildren<Renderer>()) // removes all the materials from the objects, remove when objects are single
                        f.material = null;
                    m_Module.AddComponent<VRClicked>();
                    m_Module.GetComponent<VRClicked>().AutoAdd(m_Module);
                    m_SpawnModule = true; //make sure 1 is spawned
                }
            }  


        }
        void OnTriggerExit(Collider _col)
        {
            Destroy(m_Module);
            m_SpawnModule = false;
        }




    }
}