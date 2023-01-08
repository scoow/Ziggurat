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
        UnityEngine.AI.NavMeshAgent agent;

        void Start()
        {
            agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
            // ”казаие точки назначени€
/*            target = FindObjectOfType<UnitsContainer>().transform;//todo сделать настраиваемый RallyPoint

            SetTarget(target);*/

            _unitEnvironment = GetComponent<UnitEnvironment>();
        }

        public void SetTarget(Transform target)
        {
            agent.destination = target.position;
        }

        public void StartAnim(string animation)//исправить
        {
            _unitEnvironment.StartAnimation(animation);
        }

        private void Update() //todo анимаци€ при ходьбе
        {
            if (agent.velocity.magnitude > 1)
            {
                _unitEnvironment.Moving(agent.speed);
            }
            else
            {
                _unitEnvironment.Moving(0f);
                //_unitEnvironment.StartAnimation("Die");
            }
        }
    }
}