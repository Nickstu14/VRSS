using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModuleObjects : MonoBehaviour
{
    public enum Module
    {
        //None,
        // ControlRoom,
        Connection2,
        Connection4,
        Connection6,
        SolarPannel,
        // PowerRoom,
        LifeSupport,
        // O2Container,
        // OxygenRecycle,
        DockStation1,
        // DockStation2,
        // ItemStorage,
        // CrewQuaters,
        // Medical,
        // ResearchLab,
        // Plantation,
        // CommsRoom,
        // Engineering,
        //  ForceFeild
    };

    // Use this for initialization
    public GameObject s_ControllRoom;
    public GameObject s_Connection2;
    public GameObject s_Connection4;
    public GameObject s_Connection6;
    public GameObject s_SolarPannel;
    public GameObject s_LifeSupport;
    public GameObject s_DockStation1;


    public GameObject DisplayModule(Module _ModNum)
    {
        switch(_ModNum)
        {
            case Module.Connection2: return s_Connection2;
                break;
            case Module.Connection4:return s_Connection4;
                break;
            case Module.Connection6:return s_Connection6;
                break;
            case Module.DockStation1:return s_DockStation1;
                break;
            case Module.LifeSupport:return s_LifeSupport;
                break;
            case Module.SolarPannel:return s_SolarPannel;
                break;
            default: return null;
                break;
        }
    }
   public GameObject GetControllRoom()
    {
        return s_ControllRoom;
    }


}
