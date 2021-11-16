using System.Collections;
using System.Collections.Generic;
using Com.GwennDiaz.Utils.Replace;
using UnityEngine;

namespace Com.GwennDiaz.Utils.Replace
{
    [CreateAssetMenu(menuName = "Utils/Replace/String")]
    public class StringReplace : ScriptableObject
    {
        public List<CharReplace> charReplaces;
    }
}
