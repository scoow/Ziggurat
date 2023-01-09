using UnityEngine;
//using Zenject;


/*TODO
 * 1. �������� ������������� ����� �����
 * 2. �������� ������� �� � ������
 * 3. �������� ������� ��������� ������������� �� ���������
 * 4. ���������� ���
 * 5. �������������� ��
 * 6. �������� UI, ��� ����� �� �������
 */

namespace Ziggurat
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;

        public SpawnAssistant _spawnAssistant;
        public ConfigurationAssistant _configurationAssistant;
        public AIAssistant _aiAssistant;//


        private void Awake()
        {
            instance = this;
        }
        private void OnEnable()
        {
            _spawnAssistant = GetComponent<SpawnAssistant>();
            _configurationAssistant = GetComponent<ConfigurationAssistant>();
            _aiAssistant = GetComponent<AIAssistant>();
        }
    }
}