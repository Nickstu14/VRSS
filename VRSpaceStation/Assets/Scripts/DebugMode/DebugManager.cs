﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Desktop
{
    [AddComponentMenu("VRSS/Desktop/DebugManager")]
    public class DebugManager : MonoBehaviour
    {
        [SerializeField]
        public GameManager m_GM;
        public GameManager.GameMode m_GMMode;
        public DebugScreenText m_DebugScreen;
        public Camera m_Cam;

        // Use this for initialization
        void Start()
        {
            m_GM = GetComponent<GameManager>();
            m_Cam =  GetComponentInChildren<Camera>();
            m_DebugScreen = GetComponentInChildren<DebugScreenText>();
            
        }

        // Update is called once per frame
        void Update()
        {
            if (m_DebugScreen != null)
            {
                if (m_GM.GetMode() == GameManager.GameMode.DeskTop)
                    m_DebugScreen.SetMode("Desktop");
                else if (m_GM.GetMode() == GameManager.GameMode.Vr)
                    m_DebugScreen.SetMode("VR");
                if (m_Cam != null)
                    m_DebugScreen.SetCamPos(m_Cam.transform.position);
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