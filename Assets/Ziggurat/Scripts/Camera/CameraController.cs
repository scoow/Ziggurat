using UnityEngine;

namespace Ziggurat
{
    public class CameraController : MonoBehaviour
    {
        private Vector3 _movementVector = Vector3.zero;
        private Controls _controls;

        [SerializeField]
        private float _cameraMoveSpeed = 20;
        [SerializeField]
        private float _scaleSensitivity = 2;
        [SerializeField]
        private float _rotateSensitivity = 30;

        private void OnEnable()
        {
            _controls = new Controls();
            _controls.Enable();

            _controls.CameraActionMap.WASD.performed += callbackContext => SetMovement(callbackContext.ReadValue<Vector2>());
            _controls.CameraActionMap.WASD.canceled += callbackContext => CancelMove();

            _controls.CameraActionMap.Scale.performed += callbackContext => SetScale(callbackContext.ReadValue<float>());
            _controls.CameraActionMap.Rotate.performed += callbackContext => Rotate(callbackContext.ReadValue<float>());
        }
        private void CancelMove()
        {
            _movementVector = Vector2.zero;
        }
        private void SetMovement(Vector2 movement)
        {
            _movementVector = new Vector3(movement.x, 0f, movement.y) * _cameraMoveSpeed;
        }
        private void SetScale(float scale)
        {
            _movementVector = new Vector3(0f, scale * _scaleSensitivity, 0f);
        }
        private void Rotate(float angle)
        {
            transform.Rotate(Time.deltaTime * _rotateSensitivity * new Vector3(0f, angle, 0f));
        }
        private void Move()
        {
            transform.Translate(Time.deltaTime * _movementVector);
        }
        private void Update()
        {
            Move();
        }
        private void OnDisable()
        {
            _controls.Disable();
        }
    }
}