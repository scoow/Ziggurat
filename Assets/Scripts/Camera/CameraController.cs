using UnityEngine;
using UnityEngine.EventSystems;

namespace Ziggurat
{
    public class CameraController : MonoBehaviour
    {
        private Vector3 _movementVector = Vector3.zero;
        private Controls _controls;

        private float _speed = 10;
        private float _maxSpeed = 12;

        private void OnEnable()
        {
            _controls = new Controls();
            _controls.Enable();

            _controls.CameraActionMap.WASD.performed += callbackContext => SetMovement(callbackContext.ReadValue<Vector2>());
            _controls.CameraActionMap.WASD.canceled += callbackContext => CancelMove();
        }

        private void CancelMove()
        {
            _movementVector = Vector2.zero;
        }

        private void OnDisable()
        {
            _controls.Disable();
        }

        private void SetMovement(Vector2 movement)
        {
            _movementVector = new Vector3(movement.x, 0f, movement.y);
            /*if (_movementVector.magnitude > _maxSpeed)
                _movementVector *= 0.8f;*/
        }

        private void Move()
        {
            transform.Translate(Time.deltaTime * _speed * _movementVector);
        }

        private void Update()
        {
            Move();
        }
    }
}
