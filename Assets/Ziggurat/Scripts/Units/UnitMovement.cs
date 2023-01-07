using System.Collections;
using System.Linq;
using UnityEngine;

namespace Ziggurat
{
    public class UnitMovement : MonoBehaviour
    {
        // ��������� ����� ����������
        public Transform target;
        /// <summary>
        /// ��������� ������� (�����������)
        /// </summary>


        [SerializeField]
        //private float _attackDistance = 2;

        private UnitEnvironment _unitEnvironment;

        // ��������� ���������� ������
        UnityEngine.AI.NavMeshAgent agent;

        void Start()
        {
            agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
            // ������� ����� ����������
/*            target = FindObjectOfType<UnitsContainer>().transform;//todo ������� ������������� RallyPoint
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

        private void Update() //todo �������� ��� ������
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