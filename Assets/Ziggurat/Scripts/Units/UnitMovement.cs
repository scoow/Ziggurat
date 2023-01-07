using System.Collections;
using System.Linq;
using UnityEngine;

namespace Ziggurat
{
    public class UnitMovement : MonoBehaviour
    {
        // Положение точки назначения
        public Transform target;
        /// <summary>
        /// Дальность взгляда (обнаружения)
        /// </summary>


        [SerializeField]
        //private float _attackDistance = 2;

        private UnitEnvironment _unitEnvironment;

        // Получение компонента агента
        UnityEngine.AI.NavMeshAgent agent;

        void Start()
        {
            agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
            // Указаие точки назначения
/*            target = FindObjectOfType<UnitsContainer>().transform;//todo сделать настраиваемый RallyPoint
                                                                  //target = FindNearestTarget();

            SetTarget(target);*/


            //agent.destination = target.position;
            _unitEnvironment = GetComponent<UnitEnvironment>();
            // StartCoroutine(WaitAndSeek(5));
        }

        public void SetTarget(Transform target)
        {
            agent.destination = target.position;
        }

        private void Update() //todo анимация при ходьбе
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

/*        */
    }
}