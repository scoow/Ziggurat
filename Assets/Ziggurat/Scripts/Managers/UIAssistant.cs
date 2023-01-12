using System.Collections;
using UnityEngine;

namespace Ziggurat
{
    public class UIAssistant : MonoBehaviour
    {
        public StatsMenu _statsMenu;
        private RectTransform _currentPosition;
        private RectTransform _startPosition;
        private RectTransform _endPosition;

        private void Start()
        {
            _statsMenu= FindObjectOfType<StatsMenu>();
            _startPosition = _statsMenu.GetComponent<RectTransform>();
            _endPosition = _startPosition;

            
            
            _endPosition.position += new Vector3(0f, 100f, 0f);
        }
        public void OpenMenu()
        {
            StartCoroutine(SmoothMenuOpen());
        }


        public IEnumerator SmoothMenuOpen()
        {
            transform.position = Vector3.Lerp(_startPosition.position, _endPosition.position, 1);
            yield return null;
        }
    }
}