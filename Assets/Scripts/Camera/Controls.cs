//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Scripts/Camera/Controls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Ziggurat
{
    public partial class @Controls : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @Controls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""CameraActionMap"",
            ""id"": ""3b938569-ebf4-444a-ae9f-d1628d7544f7"",
            ""actions"": [
                {
                    ""name"": ""WASD"",
                    ""type"": ""Value"",
                    ""id"": ""c1482926-874d-4784-819c-8991dde4af80"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Scale"",
                    ""type"": ""Value"",
                    ""id"": ""f46b5ca2-aa4d-4275-a2f8-465dcc20006c"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""f62e61f9-e7bb-400c-bbb2-cb8e141a27d4"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0a2bc018-1d9c-41b0-a4d1-0761a057f8b0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""260fc5b6-4b95-446c-babb-e805e7c65a8e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9071e200-22d6-4f61-8090-7cef82d392ef"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2080be45-0f4e-4dad-8705-19658af5aa70"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""98450cce-d4e7-49b0-9e91-e7a7c2fdeeb8"",
                    ""path"": ""<Mouse>/scroll/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scale"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // CameraActionMap
            m_CameraActionMap = asset.FindActionMap("CameraActionMap", throwIfNotFound: true);
            m_CameraActionMap_WASD = m_CameraActionMap.FindAction("WASD", throwIfNotFound: true);
            m_CameraActionMap_Scale = m_CameraActionMap.FindAction("Scale", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }
        public IEnumerable<InputBinding> bindings => asset.bindings;

        public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
        {
            return asset.FindAction(actionNameOrId, throwIfNotFound);
        }
        public int FindBinding(InputBinding bindingMask, out InputAction action)
        {
            return asset.FindBinding(bindingMask, out action);
        }

        // CameraActionMap
        private readonly InputActionMap m_CameraActionMap;
        private ICameraActionMapActions m_CameraActionMapActionsCallbackInterface;
        private readonly InputAction m_CameraActionMap_WASD;
        private readonly InputAction m_CameraActionMap_Scale;
        public struct CameraActionMapActions
        {
            private @Controls m_Wrapper;
            public CameraActionMapActions(@Controls wrapper) { m_Wrapper = wrapper; }
            public InputAction @WASD => m_Wrapper.m_CameraActionMap_WASD;
            public InputAction @Scale => m_Wrapper.m_CameraActionMap_Scale;
            public InputActionMap Get() { return m_Wrapper.m_CameraActionMap; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(CameraActionMapActions set) { return set.Get(); }
            public void SetCallbacks(ICameraActionMapActions instance)
            {
                if (m_Wrapper.m_CameraActionMapActionsCallbackInterface != null)
                {
                    @WASD.started -= m_Wrapper.m_CameraActionMapActionsCallbackInterface.OnWASD;
                    @WASD.performed -= m_Wrapper.m_CameraActionMapActionsCallbackInterface.OnWASD;
                    @WASD.canceled -= m_Wrapper.m_CameraActionMapActionsCallbackInterface.OnWASD;
                    @Scale.started -= m_Wrapper.m_CameraActionMapActionsCallbackInterface.OnScale;
                    @Scale.performed -= m_Wrapper.m_CameraActionMapActionsCallbackInterface.OnScale;
                    @Scale.canceled -= m_Wrapper.m_CameraActionMapActionsCallbackInterface.OnScale;
                }
                m_Wrapper.m_CameraActionMapActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @WASD.started += instance.OnWASD;
                    @WASD.performed += instance.OnWASD;
                    @WASD.canceled += instance.OnWASD;
                    @Scale.started += instance.OnScale;
                    @Scale.performed += instance.OnScale;
                    @Scale.canceled += instance.OnScale;
                }
            }
        }
        public CameraActionMapActions @CameraActionMap => new CameraActionMapActions(this);
        public interface ICameraActionMapActions
        {
            void OnWASD(InputAction.CallbackContext context);
            void OnScale(InputAction.CallbackContext context);
        }
    }
}
