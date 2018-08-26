using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Module
{
    [AddComponentMenu("VRSS/Module/Cabin")]
    public class Cabin : MonoBehaviour
    {
        private int s_Cabin;
        // Use this for initialization
        void Start()
        {
            s_Cabin = 50;

        }
        public int GetCabin ()
        {
            return s_Cabin;
        }
    }
}