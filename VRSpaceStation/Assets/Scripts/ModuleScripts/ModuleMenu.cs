using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Menu
{
    public class ModuleMenu : MonoBehaviour
    {
        private bool m_MouseOver;
        private bool m_Show;
        // Use this for initialization
        void Start()
        {
            m_MouseOver = false;
            
        }

        // Update is called once per frame
        void Update()
        {

        }

        void LateUpdate()
        {
            
        }

        void OnMouseOver()
        {// If the mouse hovers over this module then set the bool to true
            m_MouseOver = true;
        }
        void OnMouseExit()
        {// If the mouse moves away from this module then set the bool to false
            m_MouseOver = false;
        }

        public bool GetMouseOver()
        {
            return m_MouseOver; //other scripts will be able to retreve the information if the mouse is over or not
        }

        public void SetShowMenu (bool _val)
        {
            m_Show = _val;
        }
        public bool GetShowMenu()
        {
            return m_Show;
        }

    }
}
