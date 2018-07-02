using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Menu

{
    public class MenuButton : MonoBehaviour
    {
        [SerializeField]
        public Text m_text;
        [SerializeField]
        private MenuManager m_MenuManager;

        //renames the text
        public void SetText(string textName)
        {
            m_text.text = textName;
        }

        public void OnClick()
        {
            m_MenuManager.ButtonClicked(m_text.text);
        }
    }
}