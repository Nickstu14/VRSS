using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum GameMode
    {
        Vr,
        DeskTop,
        Debug
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
        m_Mode = GameMode.Debug; //Debug by default
    }

    // Update is called once per frame
    void Update()
    {
        switch (m_Mode)
        {
            case GameMode.Debug:
                ModeSwitch(false, false, true);
                break;
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
