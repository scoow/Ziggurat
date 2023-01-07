using UnityEngine;

namespace Ziggurat
{
    public class UnitMovement : MonoBehaviour
    {
        // Положение точки назначения
        public Transform target;

        [SerializeField]
        private float _sightDistance = 5;

        private UnitEnvironment _unitEnvironment;

        // Получение компонента агента
        UnityEngine.AI.NavMeshAgent agent;

        void Start()
        {
            agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
            // Указаие точки назначения
            target = FindObjectOfType<UnitsContainer>().transform;//todo сделать настраиваемый RallyPoint
            agent.destination = target.position;
            _unitEnvironment = GetComponent<UnitEnvironment>();
        }
        private void Update() //todo анимация при ходьбе
        {
            if (agent.velocity.magnitude > 1)
            {
                _unitEnvironment.Moving(agent.speed);
                //Debug.Log("Moving");
            }
            else
            {
                _unitEnvironment.Moving(0f);
                //_unitEnvironment.StartAnimation("Die");
            }
        }

        private bool CheckDistance(Vector3 target)//
        {
            return (this.transform.position + target).magnitude < _sightDistance;
        }

        private Transform FindNearestTarget()//todo вынести в другой класс
        {
            return null;
        }
    }
}