using UnityEngine.InputSystem;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;
using System;

namespace Ziggurat
{
    public class CameraController : MonoBehaviour
    {
        private Vector2 _movementVector = Vector2.zero;
        private Controls _controls;
        private void OnEnable()
        {
            _controls = new Controls();
            _controls.Enable();

            _controls.CameraActionMap.WASD.performed += callbackContext => Move(callbackContext.ReadValue<Vector2>());
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

        private void Move(Vector2 movement)
        {
            _movementVector += movement;
            transform.Translate(_movementVector.x, 0f, _movementVector.y);
            //transform.Translate(movement);
        }
    }
}
