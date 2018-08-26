using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Module
{
    [AddComponentMenu("VRSS/Module/Moveable")]
    public class Moveable : MonoBehaviour
    {
        private bool m_Move;

        // Use this for initialization
        void Start()
        {
            m_Move = true;
        }

        public bool GetMove()
        {
            return m_Move;
        }
        public void SetMove(bool _Val)
        {
            m_Move = _Val;
        }

    }

}