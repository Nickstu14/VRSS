using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // [System.Serializable]
    public enum GameMode
    {
        Vr,
       // DebugVr,
        DeskTop,
        //Debug
    };

    [Header("Game Mode")]
    public GameMode m_Mode;
    [Header("VR")]
    public GameObject m_VrGameObject;
    [Header("Desktop")]
    public GameObject m_DesktopGameObject;
    [Header("Debug")]
    public GameObject m_DebugGameObject;
    [Header("Desktop Canvas")]
    public GameObject m_Canvas;

    private Menu.MenuManager m_MenuManager;
    public Desktop.DebugManager m_DM;
    void Start()
    {
        m_Mode = GameMode.DeskTop; //Debug by default
        m_MenuManager = GetComponent<Menu.MenuManager>();
        m_DM = GetComponent<Desktop.DebugManager>();
    }

    // Update is called once per frame
    void Update()
    {
        KeyboardInput();
        ModeChoice();
        m_DM.SetMode(m_Mode);
    }

    void KeyboardInput()
    {
        if (Input.GetKey(KeyCode.F1))
            m_Mode = GameMode.Vr;
        else if (Input.GetKey(KeyCode.F2))
            m_Mode = GameMode.DeskTop;
    }

    void ModeChoice()
    {
        switch (m_Mode)
        {
            case GameMode.DeskTop:
                ModeSwitch(false, true);
                m_MenuManager.SetActiveMenu(true);
                break;
            case GameMode.Vr:
                ModeSwitch(true, false);
                break;
        }
    }

    void ModeSwitch(bool _Vr, bool _Desk)
    {//turns the correct mode on & the others off
        m_VrGameObject.SetActive(_Vr);
        m_DesktopGameObject.SetActive(_Desk);
    }

  

}
