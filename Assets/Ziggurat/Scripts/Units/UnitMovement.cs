using UnityEngine;
using UnityEngine.AI;

//todo ������� ����� ��� ���������� ���������
namespace Ziggurat
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class UnitMovement : MonoBehaviour
    {
        // ��������� ����� ����������
        public Transform target;

        [SerializeField]
        //private float _attackDistance = 2;

        private UnitEnvironment _unitEnvironment;

        // ��������� ���������� ������
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

        public void StartAnimation(string animation)//���������
        {
            _unitEnvironment.StartAnimation(animation);
        }

        private void Update() //todo �������� ��� ������
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