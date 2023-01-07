using UnityEngine;

namespace Ziggurat
{
    public class UnitMovement : MonoBehaviour
    {
        // ��������� ����� ����������
        public Transform target;

        [SerializeField]
        private float _sightDistance = 5;

        private UnitEnvironment _unitEnvironment;

        // ��������� ���������� ������
        UnityEngine.AI.NavMeshAgent agent;

        void Start()
        {
            agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
            // ������� ����� ����������
            target = FindObjectOfType<UnitsContainer>().transform;//todo ������� ������������� RallyPoint
            agent.destination = target.position;
            _unitEnvironment = GetComponent<UnitEnvironment>();
        }
        private void Update() //todo �������� ��� ������
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

        private Transform FindNearestTarget()//todo ������� � ������ �����
        {
            return null;
        }
    }
}