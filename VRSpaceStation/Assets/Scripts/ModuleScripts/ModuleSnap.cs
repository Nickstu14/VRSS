using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Module
{

    public class ModuleSnap : MonoBehaviour
    {
        public Vector3 s_SnapPos;
        public GameObject test;

        void Start()
        {
            if (transform.FindChild("SnapLocation") != null)
            {
                s_SnapPos = transform.FindChild("SnapLocation").transform.position;
                if (test != null)
                {
                    GameObject t_Go = Instantiate(test, s_SnapPos, Quaternion.identity, gameObject.transform.parent);
                    //t_Go.transform.localScale = Vector3.one;
                }
            }
        }

        void Update()
        {

        }

        void OnTriggerEnter(Collider _Col)
        {
            //if value is greater than current then set pos at +0.1
            //if value is less then current then set pos at -0.1
            //if(_Col.transform.position.x >)
        }



        public Vector3 GetSnapPos()
        {
            return s_SnapPos;
        }

        /*
        Notes:
        Still need to add in the snap posistion for now hard place them in but eventually 
        dynamically have them created at runtime or have an inspector script sort it.

        */

    }
}