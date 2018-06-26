using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
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
    // Use this for initialization
    void Start()
    {
        m_Mode = GameMode.DeskTop; //Debug by default
    }

    // Update is called once per frame
    void Update()
    {
        KeyboardInput();
        ModeChoice();

    }

    void KeyboardInput()
    {
        if (Input.GetKey(KeyCode.F1))
            m_Mode = GameMode.Vr;
        else if (Input.GetKey(KeyCode.F2))
            m_Mode = GameMode.DeskTop;
        //else if (Input.GetKey(KeyCode.F3))
            //m_Mode = GameMode.Debug;
        //else if (Input.GetKey(KeyCode.F4)) //for debugVr Mode
            //m_Mode = GameMode.DebugVr;
    }

    void ModeChoice()
    {
        switch (m_Mode)
        {
            /*case GameMode.Debug:
                ModeSwitch(false, false, true);
                break;*/
            case GameMode.DeskTop:
                ModeSwitch(false, true, false);
                break;
            case GameMode.Vr:
                ModeSwitch(true, false, false);
                break;
        }
    }

    void ModeSwitch(bool _Vr, bool _Desk, bool _Debug)
    {//turns the correct mode on & the others off
        m_VrGameObject.SetActive(_Vr);
        m_DesktopGameObject.SetActive(_Desk);
        m_DebugGameObject.SetActive(_Debug);
    }
}
