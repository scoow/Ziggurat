using UnityEngine;

//todo сделать класс дл€ управлени€ движением
namespace Ziggurat
{
    public class UnitMovement : MonoBehaviour
    {
        // ѕоложение точки назначени€
        public Transform target;

        [SerializeField]
        //private float _attackDistance = 2;

        private UnitEnvironment _unitEnvironment;

        // ѕолучение компонента агента
        private UnityEngine.AI.NavMeshAgent _agent;

        void Start()
        {
            _agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
            // ”казаие точки назначени€
/*            target = FindObjectOfType<UnitsContainer>().transform;//todo сделать настраиваемый RallyPoint*/



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

        private void Update() //todo анимаци€ при ходьбе
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