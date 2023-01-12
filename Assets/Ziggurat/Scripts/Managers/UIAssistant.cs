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

            _currentPosition = _statsMenu.GetComponent<RectTransform>();

            _startPosition = _currentPosition;
            _endPosition = _startPosition;
            _endPosition.position += new Vector3(0f, 100f, 0f);
        }
        public void OpenMenu(UnitType unitType)
        {
            _statsMenu.ReadStats(unitType);//рптимизировать
            _statsMenu.HideOrShow();
        }

        public IEnumerator SmoothMenuOpen()
        {
            float currentTime = 0f;

            while (currentTime < 2)
            {
                _currentPosition.transform.position = Vector3.Lerp(_startPosition.position, _endPosition.position, currentTime);
                currentTime += Time.deltaTime;
                yield return null;
            }
            _currentPosition.transform.position = _endPosition.position;
        }
    }
}