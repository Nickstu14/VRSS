using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Staff
{
    public class LoadFromText : MonoBehaviour
    {

        public TextAsset [] s_TextFiles; // hardcoded 

        public List<string> m_FornameFemale;
        public List<string> m_FornameMale;
        public List<string> m_SureName;
        public List<string> m_Jobs;

        

        // Use this for initialization
        private void Awake()
        {
            m_FornameFemale = new List<string>();
            m_FornameMale = new List<string>();
            m_SureName = new List<string>();
            m_Jobs = new List<string>();
            s_TextFiles = new TextAsset[4];

            GetTextFileLocation();

        }
        void Start()
        {

        }

        void GetTextFileLocation()
        {
            string path = "Scripts/StaffMembers/TextFiles/FemaleNames.txt";

            //Read the text from directly from the test.txt file
            s_TextFiles[0] = Resources.Load(path) as TextAsset;
            print(s_TextFiles[0]);
               // TextAsset bindata = Resources.Load("Texture") as TextAsset;

        }

        string GetForeNamesFemale()
        {
            return m_FornameFemale[Random.Range(0, m_FornameFemale.Count)];
        }

    }
}