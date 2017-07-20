using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct StockItems
{
    public string m_ItemName;
    public int m_quantity;

};

public class MainController : MonoBehaviour
{

    [Header("List of Attached Modules")]
    public List<GameObject> m_ModuleList;
    [Header("List of Personel")]
    //public List<CrewMemebers>

    [Space(5)]
    [Header("Power")]
    public int m_TotalCurrentPower;
    public int m_MaxPowerCapacity;

    [Space(5)]
    [Header("Oxygen")]
    public int m_TotalCurrentO2;
    public int m_MaxO2Capactiy;

    [Space(5)]
    [Header("Items")]
    public List<StockItems> m_StockItems;


    // Use this for initialization
    void Start()
    {
        m_ModuleList = new List<GameObject>();
        m_StockItems = new List<StockItems>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetTotalPower(int _Val)
    {
        m_TotalCurrentPower = _Val;
    }
    public void SetMaxPower(int _Val)
    {
        m_MaxPowerCapacity = _Val;
    }
    public void SetTotalO2(int _Val)
    {
        m_TotalCurrentO2 = _Val;
    }
    public void SetMaxO2(int _Val)
    {
        m_MaxO2Capactiy = _Val;
    }

    public void AddModule(GameObject _Module)
    {
        m_ModuleList.Add(_Module);
        Module.BasicModuleInfo t_ModInfo = _Module.GetComponent<Module.BasicModuleInfo>();
        m_TotalCurrentPower += t_ModInfo.m_PowerConsumption;
        
    }

}
