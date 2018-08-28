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
    private Desktop.DebugManager m_DM;
    public bool m_Debug;

    void Start()
    {
        m_Mode = GameMode.DeskTop; //Debug by default
        m_MenuManager = GetComponent<Menu.MenuManager>();
        m_DM = GetComponent<Desktop.DebugManager>();
        m_Debug = false;
    }

    // Update is called once per frame
    void Update()
    {
        KeyboardInput();
        ModeChoice();
        if (m_Mode == GameMode.DeskTop && m_Debug)
            m_DM.SetMode(m_Mode);
        m_DM.enabled = m_Debug;

    }

    void KeyboardInput()
    {
        if (Input.GetKey(KeyCode.F1))
            m_Mode = GameMode.Vr;
        else if (Input.GetKey(KeyCode.F2))
            m_Mode = GameMode.DeskTop;
        else if (Input.GetKey(KeyCode.F3))
            m_Debug = !m_Debug; ;

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
    public GameMode GetMode()
    {
        return m_Mode;
    }
  

}
