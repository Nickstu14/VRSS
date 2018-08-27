using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Desktop
{
    [AddComponentMenu("VRSS/Desktop/DebugScreenText")]
    public class DebugScreenText : MonoBehaviour
    {
        public Text m_ModeText; //Holds the text GO that will show what mode you are currently on (not sure if needed)

        public string m_Mode;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (m_Mode != null)
                m_ModeText.text = "Mode: " + m_Mode; 
        }

        public void SetMode(string _val = null)
        {
            m_Mode = _val;
        }
    }
}