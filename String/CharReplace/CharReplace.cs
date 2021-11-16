using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.GwennDiaz.Utils.Replace
{
    [CreateAssetMenu(menuName = "Utils/Replace/Char")]
    public class CharReplace : ScriptableObject
    {   
        public string oldChar;
        public string newChar;
    }
}