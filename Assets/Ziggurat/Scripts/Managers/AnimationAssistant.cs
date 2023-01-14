using UnityEngine;

namespace Ziggurat
{
    public class AnimationAssistant : MonoBehaviour
    {
        [SerializeField]
        private Configuration _configuration;

        public string AnimationByName(AnimationType animationType)
        {
            return _configuration.GetDictionary[animationType];
        }
    }
}
