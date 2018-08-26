using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Staff
{
    [System.Serializable]
    public struct StaffMember
    {
        public string m_ForName;
        public string m_Surname;
        public string m_JobTitle;
        public Gender m_Gender; // ture female, false male
    }


    [AddComponentMenu("VRSS/Staff/CreateStaff")]
    public class CreateStaff : LoadFromText
    {

       public List<StaffMember> m_StaffMember;

        


        // Use this for initialization
        void Start()
        {
            m_StaffMember = new List<StaffMember>();

            for (int i = 0;i <10;i++)
            {
                SetStaffValues(Random.Range(0, 2));
            }
        }

        void SetStaffValues(int _GenderVal)
        {
            StaffMember m_SM = new StaffMember(); //temp version of a staff member to then store in the list
            if (_GenderVal == 0) //Female
            {
                m_SM.m_ForName = GetForeNamesFemale();
                m_SM.m_Gender = Gender.FEMALE;
            }
            else //Male
            {
                m_SM.m_ForName = GetForeNamesMale();
                m_SM.m_Gender = Gender.MALE;
            }

            m_SM.m_Surname = GetSurName();

            m_StaffMember.Add(m_SM);
        }

        string GetStaffForeName(int _Val)
        {
            return m_StaffMember[_Val].m_ForName;
        }
        string GetSurName(int _Val)
        {
            return m_StaffMember[_Val].m_Surname;
        }
        string GetJob(int _Val)
        {
            return m_StaffMember[_Val].m_JobTitle;
        }
    }
}