using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;

namespace Narration
{
    public struct DelegateCallText
    {
        int delegateID;
        int stringPosition;

        DelegateCallText(int DelegateID, int StringPosition)
        {
            delegateID = DelegateID;
            stringPosition = StringPosition;
        }
    }

    //Types in this class are templates
    public class NarrationReferenceManager : MonoBehaviour
    {
        public Dictionary<int, string> m_Characters;
        public Dictionary<int, string> m_Voices;
        public Dictionary<int, string> m_AudioSources;
        public Dictionary<int, string> m_TextBoxes;
    }

    public class TextBlock : MonoBehaviour
    {
        string m_RawString = "";
        string m_ParsedString = "";
        int m_Character = 0;        //ID (guid?)
        int m_Voice = 0;            //ID (guid?)
        int m_SpeakingSpeed = 1;
        List<DelegateCallText> m_DelegateCallText = new List<DelegateCallText>();

        int m_CurChar = 0; // Current text character
        //Audio source?


        void UpdateDisplayString()
        {

        }

        TextBlock()
        {

        }

        void InterpretString()
        {

        }

        void LoadString(string RawString)
        {
            m_RawString = RawString;
            InterpretString();
        }

        void OnComplete()
        {

        }

        void Display()
        {

        }

        public void AddDelegate()
        {

        }
    }
}
