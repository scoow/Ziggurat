using UnityEngine;
using UnityEngine.AI;

//todo сделать класс для управления движением
namespace Ziggurat
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class UnitMovement : MonoBehaviour
    {
        // Положение точки назначения
        public Transform target;

        [SerializeField]
        //private float _attackDistance = 2;

        private UnitEnvironment _unitEnvironment;

        // Получение компонента агента
        private UnityEngine.AI.NavMeshAgent _agent;

        private void Awake()
        {
            _agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
            _unitEnvironment = GetComponent<UnitEnvironment>();
        }

        public void SetTarget(Transform target)
        {
            _agent.destination = target.position;
        }

        public void SetSpeed(float speed)
        {
            _agent.speed = speed;
        }

        public void StartAnimation(string animation)//исправить
        {
            _unitEnvironment.StartAnimation(animation);
        }

        private void Update() //todo анимация при ходьбе
        {
            if (_agent.velocity.magnitude > 1)
            {
                _unitEnvironment.Moving(_agent.speed);
            }
            else
            {
                _unitEnvironment.Moving(0f);
            }
        }
    }
}