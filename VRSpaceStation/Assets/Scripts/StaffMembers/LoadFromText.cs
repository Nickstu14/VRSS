using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Staff
{
    public class LoadFromText : MonoBehaviour
    {
        public List<string> m_Forname;
        public List<string> m_SureName;
        public List<string> m_Jobs;

        // Use this for initialization
        private void Awake()
        {
            
        }
        void Start()
        {

        }

        string GetForeNames()
        {
            return m_Forname[Random.Range(0, m_Forname.Count)];
        }

    }
}