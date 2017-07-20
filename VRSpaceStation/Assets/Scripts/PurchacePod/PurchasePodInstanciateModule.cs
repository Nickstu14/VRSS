using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PurchasePod
{
    public class PurchasePodInstanciateModule : MonoBehaviour
    {
       public GameObject m_Module;

        // Use this for initialization
        void Start()
        {
            m_Module = GetComponent<PurchasePodController>().m_Module;
            gameObject.tag = "PurchasePod";
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
            print("collided");
            if(_col.GetComponent<VrHandInteraction>().m_Trigger)
            {
                print("click in collider");
            }
        }

    }
}