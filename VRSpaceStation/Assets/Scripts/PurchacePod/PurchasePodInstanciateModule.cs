using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PurchasePod
{
    public class PurchasePodInstanciateModule : MonoBehaviour
    {
        public GameObject m_DisplayModule;
        public GameObject m_Module;
        public bool m_SpawnModule = false;
        public int m_val;

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
                    m_Module.AddComponent<VRClicked>();
                    m_Module.GetComponent<VRClicked>().AutoAdd(m_Module);
                    m_SpawnModule = true; //make sure 1 is spawned
                    m_val++;
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