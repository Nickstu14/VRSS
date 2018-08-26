using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

namespace Desktop
{
    /*
     Mouse manager manages what the mouse is selecting.
         */
    [AddComponentMenu("VRSS/Desktop/MouseManager")]
    public class MouseManager : MonoBehaviour
    {
        public Camera m_Camera;
        private GameObject m_selectedObject;

        public Material m_ModuleMat;
        public Material m_ModuleSelectedMat;

        private DebugScreenText m_DebugText;
        // Use this for initialization
        void Start()
        {
            // m_Camera = GetComponent<Camera>();
            m_DebugText = GetComponent<DebugScreenText>();
            m_DebugText.SetInfo("Selected: ");

            m_Camera = GetComponentInChildren<Camera>();
        }

        // Update is called once per frame
        void Update()
        {
            Ray m_ray = m_Camera.ScreenPointToRay(Input.mousePosition);

            RaycastHit m_HitInfo;

            if( Physics.Raycast(m_ray, out m_HitInfo))
            {
                GameObject m_hitObject = m_HitInfo.transform.gameObject;

                SelectObject(m_hitObject);

            }
            else
            {
                ClearSelection();
            }
           
        }

        void SelectObject(GameObject _obj)
        {
            if(m_selectedObject != null)
            {
                if (_obj == m_selectedObject)
                    return;
                ClearSelection();
            }

            m_selectedObject = _obj;

            Renderer[] m_rs = m_selectedObject.GetComponentsInChildren<Renderer>();
            foreach (Renderer m_r in m_rs)
            {
                Material m_m = m_r.material;
                m_m = m_ModuleSelectedMat;
                m_r.material = m_m;
            }

            m_DebugText.SetInfo("Selected: " + m_selectedObject.name);


        }

        void ClearSelection()
        {
            if (m_selectedObject == null)
                return;

            Renderer[] m_rs = m_selectedObject.GetComponentsInChildren<Renderer>();
            foreach (Renderer m_r in m_rs)
            {
                Material m_m = m_r.material;
                m_m = m_ModuleMat;
                m_r.material = m_m;
            }

            m_selectedObject = null;

            m_DebugText.SetInfo("Selected: " );
        }
    }
}