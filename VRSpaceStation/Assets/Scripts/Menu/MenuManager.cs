using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

namespace Menu
{
    /*
     *Menu manager, controlls the menus in the desktop side version of the game. 
     */
    [AddComponentMenu("VRSS/Menu/MenuManager")]
    public class MenuManager : MonoBehaviour
    {
        [Header("VR / Desktop")]
        [SerializeField]
        private GameObject m_Object;
        public GameObject m_ButtonTemplate;
        public GameObject m_ModuleList;

        private bool m_DesktopMode; //only true when the desktop mode is active, set by the GameManager

        private string m_ModuleButtonClicked;

        // Use this for initialization

        void Start()
        {



            for (int i = 1; i<20;i++)
            {
                GameObject m_Button = Instantiate(m_ButtonTemplate) as GameObject;
                m_Button.SetActive(true);

                m_Button.GetComponentInChildren<MenuButton>().SetText("Button " + i);

                m_Button.transform.SetParent(m_ButtonTemplate.transform.parent, false);
            }
        }

        // Update is called once per frame
        void Update()
        {
            if(m_DesktopMode)
               UpdateCanvas();
        }

        public void SetActiveMenu(bool _Active)
        {//if the desktop mode is active then the var is true
            m_DesktopMode = _Active;
        }

        void UpdateCanvas()
        {
            if (m_ModuleButtonClicked != null)
                print(m_ModuleButtonClicked);
        }



        public void ButtonClicked(string _Button)
        {
            m_ModuleButtonClicked = _Button;
        }
        public void PopulateMenu()
        {

        }


    }
}