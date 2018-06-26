using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Module
{
    public class ModuleMenu : MonoBehaviour
    {
        private bool m_MouseOver;
        private bool m_Show;
        public Camera m_Cam;
        public GameObject m_Menu;
        public Transform m_transform;
        // Use this for initialization
        void Start()
        {
            m_MouseOver = false;

            GameObject t_menu = GameObject.Find("ModuleList").GetComponent<ModuleObjects>().DisplayModule(ModuleObjects.Module.ModuleMenu);
            t_menu = Instantiate(t_menu, new Vector3(0.1f,transform.position.y,transform.position.z ), Quaternion.identity, gameObject.transform);
            t_menu.transform.localScale = new Vector3(1f, 1f, 1f);
            m_Menu = t_menu;
            m_Menu.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {

        }

        void LateUpdate()
        {
            if (m_Menu != null)
            {
                // m_Menu.SetActive(m_Show);
                m_Menu.transform.rotation = Quaternion.LookRotation(m_Cam.transform.position) * Quaternion.Euler(180, 0, 0); ;
            }
        }

        void OnMouseOver()
        {
            m_MouseOver = true;
        }
        void OnMouseExit()
        {
            m_MouseOver = false;
        }

        public bool GetMouseOver()
        {
            return m_MouseOver;
        }

        public void SetShowMenu (bool _val)
        {
            m_Show = _val;
            m_Menu.SetActive(m_Show);
        }
        public bool GetShowMenu()
        {
            return m_Show;
        }
    }
}
