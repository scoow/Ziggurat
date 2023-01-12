using UnityEngine;
//using Zenject;


/*TODO
 * 1. �������� ������������� ����� ����� DONE
 * 2. �������� ������� �� � ������ DONE
 * 3. �������� ������� ��������� ������������� �� ��������� DONE
 * 4. ���������� ���
 * 5. �������������� ��
 * 6. �������� UI, ��� ����� �� �������
 * 7. ���������� �� ������
 * 8. ������� ����� �����
 * 
 * 
 * �������������� ����������

��������� ����������� ������, ������� �������������� ������ ����������, �� �������:
������ ������ ����� - ���������� ���� ����� ������;
������ ����������� �������� - ���������/�������� ����� �������� ��� ������ ������.
�������� ������ ��������� ��� �����, � ������, ���� � ������ ����� ��� �����������;
�������� ������ �� ����������� �� ����������:
���������� ����� ������;
���������� ������ ������;
���������� ����� �� �������� ������ �����;
������ ���������� - ������������ ������� ������ ������.
 */

namespace Ziggurat
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;

        public SpawnAssistant _spawnAssistant;
        public ConfigurationAssistant _configurationAssistant;
        public AIAssistant _aiAssistant;//
        public UIAssistant _uiAssistant;

        private void Awake()
        {
            instance = this;
        }
        private void OnEnable()
        {
            _spawnAssistant = GetComponent<SpawnAssistant>();
            _configurationAssistant = GetComponent<ConfigurationAssistant>();
            _aiAssistant = GetComponent<AIAssistant>();
            _uiAssistant = GetComponent<UIAssistant>();
        }
    }
}