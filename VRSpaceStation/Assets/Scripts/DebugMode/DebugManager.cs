using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Desktop
{
    [AddComponentMenu("VRSS/Desktop/DebugManager")]
    public class DebugManager : MonoBehaviour
    {
        [SerializeField]
        public GameManager.GameMode m_GMMode;
        public DebugScreenText m_DebugScreen;

        // Use this for initialization
        void Start()
        {
            m_GMMode = GetComponent<GameManager.GameMode>();
            m_DebugScreen = GetComponentInChildren<DebugScreenText>();
        }

        // Update is called once per frame
        void Update()
        {
            if (m_DebugScreen != null)
            {
                if (m_GMMode == GameManager.GameMode.DeskTop)
                    m_DebugScreen.SetMode("Desktop");
                else if (m_GMMode == GameManager.GameMode.Vr)
                    m_DebugScreen.SetMode("VR");
            }
            else if (m_DebugScreen == null)
            {
                print("Can't find Debug Screen script");
            }
        }

        public void SetMode(GameManager.GameMode _Mode)
        {
            m_GMMode = _Mode;
        }
    }
}