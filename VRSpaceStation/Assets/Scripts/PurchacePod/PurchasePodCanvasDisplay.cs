using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PurchasePod
{
    //[AddComponentMenu("Purchase Pod/Purchase Pod Canvas Display")]
    public class PurchasePodCanvasDisplay : MonoBehaviour
    {

        public Text m_Time;
        public Text m_Cost;
        public Text m_Title;

        public Font m_font;

        public Color m_TextColour;


        // Use this for initialization
        void Start()
        {
            m_Time.font = m_font;
            m_Time.color = m_TextColour;

            m_Title.font = m_font;
            m_Title.color = m_TextColour;

            m_Cost.font = m_font;
            m_Cost.color = m_TextColour;

            
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
