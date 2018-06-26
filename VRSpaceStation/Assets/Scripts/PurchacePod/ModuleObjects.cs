using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModuleObjects : MonoBehaviour
{
    public enum Module
    {
        //None,
       // ModuleMenu,
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
    //public GameObject s_ModuleMenu;
    public GameObject s_ControllRoom;
    public GameObject s_Connection2;
    public GameObject s_Connection4;
    public GameObject s_Connection6;
    public GameObject s_SolarPannel;
    public GameObject s_PowerRoom;
    public GameObject s_LifeSupport;
    public GameObject s_O2Container;
    public GameObject s_OxygenRecycle;
    public GameObject s_DockStation1;
    public GameObject s_DockStation2;
    public GameObject s_ItemStorage;
    public GameObject s_CrewQuaters;
    public GameObject s_Medical;
    public GameObject s_ResearchLab;
    public GameObject s_Plantation;
    public GameObject s_CommsRoom;
    public GameObject s_Engineering;
    public GameObject s_ForceFeild;
    


    public GameObject DisplayModule(Module _ModNum)
    {
        switch (_ModNum)
        {
            case Module.Connection2:
                return s_Connection2;
                break;
            case Module.Connection4:
                return s_Connection4;
                break;
            case Module.Connection6:
                return s_Connection6;
                break;
            case Module.DockStation1:
                return s_DockStation1;
                break;
            case Module.LifeSupport:
                return s_LifeSupport;
                break;
            case Module.SolarPannel:
                return s_SolarPannel;
                break;
           /* case Module.ModuleMenu:
                return s_ModuleMenu;
                break;*/
            /*case Module.PowerRoom: return s_PowerRoom;
             * break;
             * case Module.O2Container: return s_OxygenRecycle;
             * break;
             * case Module.OxygenContainer: return s_OxygenRecycle;
             * break;
             * case Module.DoclStation2: return s_DockStation2;
             * break;
             * case Module.ItemStorage: return s_ItemStorage;
             * break;
             * case Module.CrewQuaters: return s_CrewQuaters;
             * break;
             * case Module.Medical: return s_Medical;
             * break;
             * case Module.ResearchLab: return s_ResearchLab;
             * break;
             * case Module.Plantation: return  s_Plantation;
             * break;
             * case Module.CommsRoom: return s_CommsRoom;
             * break;
             * case Module.Engineering: return s_Engineering;
             * break;
             * case Module.ForceFeild: return s_ForceFeild;
             * break;
             * */
            default:
                return null;
                break;
        }
    }

    public GameObject GetControllRoom()
    {
        return s_ControllRoom;
    }


}
