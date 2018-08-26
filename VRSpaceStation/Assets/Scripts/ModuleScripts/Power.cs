using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Module
{
    [AddComponentMenu("VRSS/Module/Power")]
    public class Power : MonoBehaviour
    {
        private int s_Power;
        // Use this for initialization
        void Start()
        {
            s_Power = 50;

        }
        public int GetPower()
        {
            return s_Power;

        }

    }
}