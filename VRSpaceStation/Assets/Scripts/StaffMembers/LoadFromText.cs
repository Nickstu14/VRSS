using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Staff
{
    public enum Gender
    {
        MALE,
        FEMALE
    }

    [AddComponentMenu("VRSS/Staff/LoadFromText")]
    public class LoadFromText : MonoBehaviour
    {

        private TextAsset[] s_TextFiles; // hardcoded 

        private List<string> m_FornameFemale;
        private List<string> m_FornameMale;
        private List<string> m_SurName;
        private List<string> m_Jobs;

        // Use this for initialization
        private void Awake()
        {
            m_FornameFemale = new List<string>();
            m_FornameMale = new List<string>();
            m_SurName = new List<string>();
            m_Jobs = new List<string>();
            s_TextFiles = new TextAsset[4];

            GetTextFileLocation();
        }

        void GetTextFileLocation()
        {
            string[] path = { "FemaleNames", "MaleNames", "SureNames", "Job" };
            //Read the text from directly from the test.txt file
            s_TextFiles[0] = Resources.Load(path[0]) as TextAsset;
            s_TextFiles[1] = Resources.Load(path[1]) as TextAsset;
            s_TextFiles[2] = Resources.Load(path[2]) as TextAsset;

            string[] m_names; //to store each name in an array

            m_names = s_TextFiles[0].text.Split('\n'); // splits up the string of names into individual ma,es
            foreach (string m_n in m_names)
                m_FornameFemale.Add(m_n); //adds them into the list
            m_names = null; //clears the array for below code.

            m_names = s_TextFiles[1].text.Split('\n');
            foreach (string m_n in m_names)
                m_FornameMale.Add(m_n);
            m_names = null;

            m_names = s_TextFiles[2].text.Split('\n');
            foreach (string m_n in m_names)
                m_SurName.Add(m_n);
            m_names = null;

        }

        public string GetForeNamesFemale()
        {
            return m_FornameFemale[Random.Range(0, m_FornameFemale.Count)];
        }
        public string GetForeNamesMale()
        {
            return m_FornameMale[Random.Range(0, m_FornameMale.Count)];
        }
        public string GetSurName()
        {
            return m_SurName[Random.Range(0, m_SurName.Count)];
        }
        public string GetJob()
        {
            return m_Jobs[Random.Range(0, m_Jobs.Count)];
        }

    }
}