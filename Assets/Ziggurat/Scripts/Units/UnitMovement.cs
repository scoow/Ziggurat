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
        /// <summary>
        /// Задать цель для движения
        /// </summary>
        /// <param name="target">цель</param>
        public void SetTarget(Transform target)
        {
            _agent.destination = target.position;
        }
        /// <summary>
        /// Установить скорость передвижения юнита
        /// </summary>
        /// <param name="speed"></param>
        public void SetSpeed(float speed)
        {
            _agent.speed = speed;
        }
        /// <summary>
        /// Начать анимацию
        /// </summary>
        /// <param name="animation"></param>
        public void StartAnimation(string animation)
        {
            _unitAnimator.StartAnimation(animation);
        }

        public void StopMoving()
        {
            _unitAnimator.Moving(0f);
        }
        /// <summary>
        /// Измерение ускорения для определения анимации бега
        /// </summary>
        private void Update()
        {
            _unitAnimator.Moving(_agent.velocity.magnitude);
        }
    }
}