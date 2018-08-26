using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Module
{
    [System.Serializable]
    public struct Snap
    {
        public Collider s_Colider; // specified collider
        [Space(2)]
        public Vector3 s_SnapPos;
        public float m_Offset; // how much the object will be offset to the edge of the original game object
        public bool m_Snapped;
       
    }

    [AddComponentMenu("VRSS/Module/ModuleSnap")]
    public class ModuleSnap : MonoBehaviour
    {
        //public Vector3 s_SnapPos;
        [SerializeField]
        public List<Snap> m_SnapList;
        //[Space(5)]
        // public GameObject test;   //don't know what this was used for.
        

        void Start()
        {
           

           /* if (transform.FindChild("SnapLocation") != null)
            {
               // s_SnapPos = transform.FindChild("SnapLocation").transform.position;
                if (test != null)
                {
                  //  GameObject t_Go = Instantiate(test, s_SnapPos, Quaternion.identity, gameObject.transform.parent);
                    //t_Go.transform.localScale = Vector3.one;
                }
            }*/
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



      /*  public Vector3 GetSnapPos()
        {
            return s_SnapPos;
        }*/

        /*
        Notes:
        Still need to add in the snap posistion for now hard place them in but eventually 
        dynamically have them created at runtime or have an inspector script sort it.

        */

    }
}

/*
 * bool snapped = false;
GameObject snapparent; // the gameobject this transform will be snapped to
Vector3 offset; // the offset of this object's position from the parent

Update()
{
    if (snapped == true)
    {
        //retain this objects position in relation to the parent
        transform.position = parent.transform.position + offset;
    }
}

void OnTriggerEnter(Collider col)
{
    if (col.tag == "parentblock")
    {
        snapped = true;
        snapparent = col.gameObject;
        offset = transform.position - snapparent.transform.position; //store relation to parent
    }
}
 * */
// when the game object is inside the collider of one of the locatoins a copy of the game object will appear at the position
// when the user releases the gameobject it will snap, perminently, to the new location.