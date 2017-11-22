using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Module
{
    public class OxygenContainer : MonoBehaviour
    {
        private int s_OxygenContainer;
        // Use this for initialization
        void Start()
        {
            s_OxygenContainer = 50;

        }

        // Update is called once per frame
        public int GetOxygenContainer()
        {
            return s_OxygenContainer;
        }
    }
}
