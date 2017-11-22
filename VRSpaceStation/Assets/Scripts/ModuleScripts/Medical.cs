using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Module
{
    public class Medical : MonoBehaviour
    {
        private bool s_Medical;
        // Use this for initialization
        void Start()
        {
            s_Medical = true;
        }
        public bool GetMedical ()
        {
            return s_Medical;
  
        }
    }
}