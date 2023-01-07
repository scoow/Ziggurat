using UnityEngine;

namespace Ziggurat
{
    public class UnitMovement : MonoBehaviour
    {
        // Положение точки назначения
        public Transform target;

        private UnitEnvironment _unitEnvironment;

        // Получение компонента агента
        UnityEngine.AI.NavMeshAgent agent;

        void Start()
        {
            agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
            // Указаие точки назначения
            target = FindObjectOfType<UnitsContainer>().transform;
            agent.destination = target.position;
            _unitEnvironment = GetComponent<UnitEnvironment>();
        }
        private void Update() //todo анимация при ходьбе
        {
            if (agent.velocity.magnitude > 1)
            {
                _unitEnvironment.Moving(agent.speed);
                Debug.Log("Moving");
            }
            else
            {
                _unitEnvironment.Moving(0f);
            }
           /* if (agent.speed > 2f)
            {
                _unitEnvironment.Moving(agent.speed);
            }
            else
            {
                _unitEnvironment.StartAnimation("Idle");
            }*/

        }
    }
}