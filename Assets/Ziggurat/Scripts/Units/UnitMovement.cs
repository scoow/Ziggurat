using UnityEngine;
using UnityEngine.AI;

namespace Ziggurat
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class UnitMovement : MonoBehaviour
    {
        // ��������� ����� ����������
        private UnitAnimator _unitAnimator;

        // ��������� ���������� ������
        private UnityEngine.AI.NavMeshAgent _agent;

        private void Awake()
        {
            _agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
            _unitAnimator = GetComponent<UnitAnimator>();
        }
        /// <summary>
        /// ������ ���� ��� ��������
        /// </summary>
        /// <param name="target">����</param>
        public void SetTarget(Transform target)
        {
            _agent.destination = target.position;
        }
        /// <summary>
        /// ���������� �������� ������������ �����
        /// </summary>
        /// <param name="speed"></param>
        public void SetSpeed(float speed)
        {
            _agent.speed = speed;
        }
        /// <summary>
        /// ������ ��������
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
        /// ��������� ��������� ��� ����������� �������� ����
        /// </summary>
        private void Update()
        {
            _unitAnimator.Moving(_agent.velocity.magnitude);
        }
    }
}