using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Module
{
    [AddComponentMenu("VRSS/Module/InitControllRoom")]
    public class InitControllRoom : MonoBehaviour
    {
        public ModuleObjects m_ModuleList;
        public List<Vector3> m_ModuleLocations;
        // Use this for initialization
        void Start()
        {
            m_ModuleLocations = new List<Vector3>();

            m_ModuleList = GameObject.Find("ModuleList").GetComponent<ModuleObjects>();

            GameObject t_module = GameObject.Find("ModuleList").GetComponent<ModuleObjects>().GetControllRoom();
            t_module = Instantiate(t_module, transform.position, Quaternion.identity , gameObject.transform);
            m_ModuleLocations.Add(transform.position);
            t_module.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            t_module.transform.Rotate(new Vector3(0, 0, 0));// = new Quaternion(90f, 0f, 0f,0f);
            t_module.GetComponent<Module.BasicModuleInfo>().SetMove(false);


			GameObject t_test = GameObject.Find ("ModuleList").GetComponent<ModuleObjects> ().DisplayModule (ModuleObjects.Module.Connection2);
			t_test = Instantiate (t_test, transform.position - new Vector3 (-1, 0, 0), Quaternion.identity, gameObject.transform);
			t_test.transform.localScale = new Vector3 (0.1f, 0.1f, 0.1f);   
			t_module.transform.Rotate(new Vector3(0, 0, 90));// = new Quaternion(90f, 0f, 0f,0f);

            SpawnModule(m_ModuleList.DisplayModule(ModuleObjects.Module.LifeSupport), new Vector3(1,0,0));
            SpawnModule(m_ModuleList.DisplayModule(ModuleObjects.Module.Connection6), new Vector3(1, 0, 1));
            SpawnModule(m_ModuleList.DisplayModule(ModuleObjects.Module.DockStation1), new Vector3(0, 0, 0));
        }

        // Update is called once per frame
        void Update()
        {

        }

        void SpawnModule(GameObject _Obj, Vector3 _Vec)
        {
            Vector3 m_vecLoc = ModuleCheck(transform.position - _Vec);
            GameObject m_GO = Instantiate(_Obj, m_vecLoc, Quaternion.identity, gameObject.transform);
            m_ModuleLocations.Add(m_vecLoc);
            m_GO.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            m_GO.transform.Rotate(new Vector3(0, 0, 90));
        }

        Vector3 ModuleCheck(Vector3 _Val) // If at vector3 location there is a module, then return false
        {
            foreach (Vector3 vec in m_ModuleLocations)
                if (vec != _Val)
                {
                    return _Val;
                }

            return new Vector3(1f, 1f, 1f);
        }
    }
}