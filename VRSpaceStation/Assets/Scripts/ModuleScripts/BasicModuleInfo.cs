﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Module
{

    public class BasicModuleInfo : MonoBehaviour
    {

        public int m_Time;
        public int m_Cost;

        [Header("This Modules Consumption Values")]
        public int m_PowerConsumption;

        [Space(5)][Header("Maintenance")][Range(0, 100)]
        public int m_MaintenanceVal;

        [Space(5)]
        [Header("Connecting Modules")]
        public List<GameObject> m_ConnectingModule;

        void Start()
        {
            m_MaintenanceVal = 100;
        }

        void Update()
        {
            if (m_MaintenanceVal == 0)
            {
                Destroy(gameObject);
            }
        }

        public int GetTime()
        {
            return m_Time;
        }

        public int GetCost()
        {
            return m_Cost;
        }

        public string GetTimeString()
        {
            return m_Time.ToString();
        }

        public string GetCostString()
        {
            return m_Cost.ToString();
        }

        public int GetPowerCon()
        {
            return m_PowerConsumption;
        }

        public int GetMaintVal()
        {
            return m_MaintenanceVal;
        }

        public void SetMaintVal(int _Val)
        {
            m_MaintenanceVal = _Val;
        }

    }
}
