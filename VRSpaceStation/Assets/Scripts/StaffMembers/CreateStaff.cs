using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Staff
{
   public enum Gender
    {
        MALE,
        FEMALE
    }

    public struct StaffMember
    {
        public string m_ForName;
        public string m_Surename;
        public string m_JobTitle;
        public Gender m_Gender; // ture female, false male
    }

    public class CreateStaff : LoadFromText
    {
        public List<StaffMember> m_SMember;

        // Use this for initialization
        void Start()
        {
            m_SMember = new List<StaffMember>();

            for (int i = 0;i <10;i++)
            {
                SetStaffValues(Random.Range(0, 1));
            
            }
        }

        void SetStaffValues(int Val)
        {

        }

        string GetStaffForeName(int _Val)
        {
            return m_SMember[_Val].m_ForName;
        }
        string GetSurName(int _Val)
        {
            return m_SMember[_Val].m_Surename;
        }
        string GetJob(int _Val)
        {
            return m_SMember[_Val].m_JobTitle;
        }
    }
}