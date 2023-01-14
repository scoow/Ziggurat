using UnityEngine;
using UnityEngine.AI;

namespace Ziggurat
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class UnitMovement : MonoBehaviour
    {
        // Положение точки назначения
        private UnitAnimator _unitAnimator;

        // Получение компонента агента
        private UnityEngine.AI.NavMeshAgent _agent;

        private void Awake()
        {
            _agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
            _unitAnimator = GetComponent<UnitAnimator>();
        }

        public void SetTarget(Transform target)
        {
            _agent.destination = target.position;
        }

        public void SetSpeed(float speed)
        {
            _agent.speed = speed;
        }

        public void StartAnimation(string animation)//todo исправить
        {
            _unitAnimator.StartAnimation(animation);
        }

        private void Update()
        {
            _unitAnimator.Moving(_agent.velocity.magnitude);
        }
    }
}