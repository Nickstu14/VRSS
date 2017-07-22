using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PurchasePod
{
    public class PurchasePodInstanciateModule : MonoBehaviour
    {
        public GameObject m_Module;
        public bool m_SpawnModule = false;

        // Use this for initialization
        void Start()
        {
            m_Module = GetComponent<PurchasePodController>().m_Module;
            // gameObject.tag = "PurchasePod";
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void SetModule(GameObject _Module)
        {
            m_Module = _Module;
        }

        void OnTriggerStay(Collider _col)
        {
           if(_col.GetComponent<VrHandInteraction>() != null)
            if (_col.GetComponent<VrHandInteraction>().m_Trigger && !m_SpawnModule)
            {
               
                GameObject t_Module = Instantiate(m_Module, _col.transform.position, Quaternion.identity);
                t_Module.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
                m_SpawnModule = true;
            }
        }
        void OnTriggerExit(Collider _col)
        {

            m_SpawnModule = false;
        }




    }
}