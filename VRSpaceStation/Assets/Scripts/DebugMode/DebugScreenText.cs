using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Desktop
{
    [AddComponentMenu("VRSS/Desktop/DebugScreenText")]
    public class DebugScreenText : MonoBehaviour
    {
        public Text m_Text;
        public string m_info;

        // Use this for initialization
        void Start()
        {
      
        }

        // Update is called once per frame
        void Update()
        {
            if (m_info != null)
                m_Text.text = m_info;
        }

        public void SetInfo(string _val)
        {
            m_info = _val;
        }
    }
}