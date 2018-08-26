using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace PurchasePod
{
    [AddComponentMenu("VRSS/VR/Purchase Pod/Purchase Pod Module Spin")]
    public class PurchacePodModuleSpin : MonoBehaviour
    {
        public PurchasePodController m_Contoller;

        void Start()
        {
            m_Contoller = GetComponentInParent<PurchasePodController>();
        }
        void Update()
        {
            transform.Rotate(new Vector3(0f, Time.deltaTime * m_Contoller.m_Spinspeed, 0f));
        }
    }
}