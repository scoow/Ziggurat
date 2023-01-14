using UnityEngine;
//using Zenject;


/*TODO
 * 1. �������� ������������� ����� ����� DONE
 * 2. �������� ������� �� � ������ DONE
 * 3. �������� ������� ��������� ������������� �� ��������� DONE
 * 4. �������������� ��
 * 5. �������� UI, ��� ����� �� ������� DONE
 * 
 * 
 * �������������� ����������

��������� ����������� ������, ������� �������������� ������ ����������, �� �������:
������ ������ ����� - ���������� ���� ����� ������; DONE
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

        private ConfigurationAssistant _configurationAssistant;
        public ConfigurationAssistant ConfigurationAssistant => _configurationAssistant;
        private SpawnAssistant _spawnAssistant;
        public SpawnAssistant SpawnAssistant => _spawnAssistant;
        private AIAssistant _aiAssistant;
        public AIAssistant AIAssistant => _aiAssistant;
        private UIAssistant _uiAssistant;
        public UIAssistant UIAssistant => _uiAssistant;
        private AnimationAssistant _animationAssistant;
        public AnimationAssistant AnimationAssistant => _animationAssistant;
        private CameraController _cameraController;
        public CameraController CameraController => _cameraController;
        private void Awake()
        {
            instance = this;
        }
        private void OnEnable()
        {
            _configurationAssistant = GetComponent<ConfigurationAssistant>();

            _spawnAssistant = GetComponent<SpawnAssistant>();
           
            _aiAssistant = GetComponent<AIAssistant>();

            _uiAssistant = GetComponent<UIAssistant>();

            _animationAssistant= GetComponent<AnimationAssistant>();

            _cameraController = FindObjectOfType<CameraController>();
        }
    }
}