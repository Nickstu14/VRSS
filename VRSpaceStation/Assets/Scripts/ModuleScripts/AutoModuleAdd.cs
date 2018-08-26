using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Module
{
    [AddComponentMenu("VRSS/Module/AutoModuleAdd")]

    public class AutoModuleAdd : MonoBehaviour
    {
        [Header("Basic Module Information")]
        public int m_Time;
        public int m_Cost;
        public int m_Power;

        [HideInInspector]
        public bool m_LifeSupport;
        public int m_MaxO2;
        public int m_MaxPopulation;

        //public GUIStyle m_styles;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void AutoAddModuleScripts()
        {
            gameObject.AddComponent<BasicModuleInfo>();
            gameObject.GetComponent<BasicModuleInfo>().m_Time = m_Time;
            gameObject.GetComponent<BasicModuleInfo>().m_Cost = m_Cost;

            if (m_LifeSupport)
            {
                gameObject.AddComponent<LifeSupport>();
                gameObject.GetComponent<LifeSupport>().SetMaxValues(m_MaxPopulation, m_MaxO2);
            }
        }

        public void SetPopulation(int _val)
        {
            m_MaxPopulation = _val;
        }
        public void SetO2(int _Val)
        {
            m_MaxO2 = _Val;
        }




    }
}
