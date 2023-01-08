using System.Collections;
using System.Linq;
using UnityEngine;

namespace Ziggurat
{
    public class UnitMovement : MonoBehaviour
    {
        // ��������� ����� ����������
        public Transform target;



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

            SetTarget(target);*/

            _unitEnvironment = GetComponent<UnitEnvironment>();
        }

        public void SetTarget(Transform target)
        {
            agent.destination = target.position;
        }

        public void StartAnim(string animation)//���������
        {
            _unitEnvironment.StartAnimation(animation);
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
    }
}