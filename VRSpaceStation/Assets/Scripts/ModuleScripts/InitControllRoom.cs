using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Module
{
    public class InitControllRoom : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            GameObject t_module = GameObject.Find("ModuleList").GetComponent<ModuleObjects>().GetControllRoom();
            t_module = Instantiate(t_module, transform.position, Quaternion.identity , gameObject.transform);
            t_module.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            t_module.transform.Rotate(new Vector3(0, 0, 90));// = new Quaternion(90f, 0f, 0f,0f);
            t_module.GetComponent<Module.BasicModuleInfo>().SetMove(false);
          
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}