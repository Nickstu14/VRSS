using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Desktop
{
    [AddComponentMenu("VRSS/Desktop/DebugScreenText")]
    public class DebugScreenText : MonoBehaviour
    {
        public Text m_ModeText; //Holds the text GO that will show what mode you are currently on (not sure if needed)

        public string m_Mode;
        public string m_CamPos;

        // Use this for initialization
        void Start()
        {
          
        }

        // Update is called once per frame
        void Update()
        {
            if (m_Mode != null)
                m_ModeText.text = DisplayText(); //"Mode: " + m_Mode;
            //if (m_CamPos != null)
               // m_CamPos.text = "Pos: " + m_VCamPos;
        }

        String DisplayText() //Anything to display debug will be added here
        {
            return
                "Mode: " + m_Mode +
                "\nPos: " + m_CamPos;
        }

        public void SetMode(string _val = null)
        {
            m_Mode = _val;
        }
        public void SetCamPos(Vector3 _Val)//float _X = 0, float _Y = 0, float _Z = 0 )
        {
            m_CamPos = "X: " + Math.Round(_Val.x,2) +
                " Y: " + Math.Round(_Val.y,2) +
                " Z: " + Math.Round(_Val.z,2);
        }

        
    }
}