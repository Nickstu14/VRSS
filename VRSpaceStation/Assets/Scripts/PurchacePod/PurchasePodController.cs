using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PurchasePod
{
    // [AddComponentMenu("Purchase Pod/Purchase Pod Controller")]
    public class PurchasePodController : MonoBehaviour
    {
        public GameObject m_Module;
        public ModuleObjects.Module m_ModuleNum;
        // public List<GameObject> s_Modules;

        public Text m_TimeDisplay; //Display text Not for editing 
        public Text m_CostDisplay; //Display text Not for editing
                                   //Visual changes see P'P'CanvasDisplay
        public string m_ErrorMsg;

        public Material m_DisplayMaterial;

        [Range(0, 20)]
        public float m_ModuleHeight;

        [Range(10, 100)]
        public float m_Spinspeed;



        void Start()
        {
            m_Module = GameObject.Find("ModuleList").GetComponent<ModuleObjects>().DisplayModule(m_ModuleNum);
            if (m_Module != null)
            {
                GetComponent<PurchasePodInstanciateModule>().SetModule(m_Module);

                GameObject m_GO = Instantiate(m_Module, Position(), Quaternion.identity);
                m_GO.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
                m_GO.AddComponent<PurchacePodModuleSpin>();
                m_GO.transform.parent = transform;

                //Changing Material of PP display model
                foreach (Renderer f in m_GO.GetComponentsInChildren<Renderer>())
                    f.material = m_DisplayMaterial;

                if (m_Module.GetComponent<Module.BasicModuleInfo>() != null)
                {
                    m_TimeDisplay.text = m_Module.GetComponent<Module.BasicModuleInfo>().GetTimeString();
                    m_CostDisplay.text = m_Module.GetComponent<Module.BasicModuleInfo>().GetCostString();
                }
                else
                {
                    m_TimeDisplay.text = m_ErrorMsg;
                    m_CostDisplay.text = m_ErrorMsg;
                }
            }
        }



        Vector3 Position()
        {
            Vector3 m_pos = gameObject.transform.position;
            m_pos.y = gameObject.transform.position.y + m_ModuleHeight;
            return m_pos;
        }


    }
}
