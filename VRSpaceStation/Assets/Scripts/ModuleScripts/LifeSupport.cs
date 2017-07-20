using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Module
{
    public class LifeSupport : MonoBehaviour
    {
        public int s_PopulationCapacity;
        public int s_MaxO2;

        public int m_CurrentO2;
        // Use this for initialization
        /*void Start()
        {

        }*/

        // Update is called once per frame
       /* void Update()
        {

        }*/

        public void SetMaxValues(int _maxPopulation, int _maxO2)
        {
            s_PopulationCapacity = _maxPopulation;
            s_MaxO2 = _maxO2;
        }

        public int GetPopulationCapacity()
        {
            return s_PopulationCapacity;
        }
        public int GetMaxO2()
        {
            return s_MaxO2;
        }
        public int GetCurrentO2()
        {
            return m_CurrentO2;
        }
        public void SetO2(int _O2)
        {
            m_CurrentO2 = _O2;
        }
    }
}