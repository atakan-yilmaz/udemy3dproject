// GENERATED AUTOMATICALLY FROM 'Assets/game folder/scripts/concretes/input/defaultAction.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace firstUdemyProject.input
{
    public class @defaultAction : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @defaultAction()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""defaultAction"",
    ""maps"": [
        {
            ""name"": ""Rocket"",
            ""id"": ""cfebcbbc-030d-485a-947a-4d2de5841f6a"",
            ""actions"": [
                {
                    ""name"": ""ForceUp"",
                    ""type"": ""PassThrough"",
                    ""id"": ""35c641f6-5e03-48f2-a68f-429cd2d4a311"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cbaf179e-3c30-4732-bdcf-86a7a586018f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForceUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Rocket
            m_Rocket = asset.FindActionMap("Rocket", throwIfNotFound: true);
            m_Rocket_ForceUp = m_Rocket.FindAction("ForceUp", throwIfNotFound: true);
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

        // Rocket
        private readonly InputActionMap m_Rocket;
        private IRocketActions m_RocketActionsCallbackInterface;
        private readonly InputAction m_Rocket_ForceUp;
        public struct RocketActions
        {
            private @defaultAction m_Wrapper;
            public RocketActions(@defaultAction wrapper) { m_Wrapper = wrapper; }
            public InputAction @ForceUp => m_Wrapper.m_Rocket_ForceUp;
            public InputActionMap Get() { return m_Wrapper.m_Rocket; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(RocketActions set) { return set.Get(); }
            public void SetCallbacks(IRocketActions instance)
            {
                if (m_Wrapper.m_RocketActionsCallbackInterface != null)
                {
                    @ForceUp.started -= m_Wrapper.m_RocketActionsCallbackInterface.OnForceUp;
                    @ForceUp.performed -= m_Wrapper.m_RocketActionsCallbackInterface.OnForceUp;
                    @ForceUp.canceled -= m_Wrapper.m_RocketActionsCallbackInterface.OnForceUp;
                }
                m_Wrapper.m_RocketActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @ForceUp.started += instance.OnForceUp;
                    @ForceUp.performed += instance.OnForceUp;
                    @ForceUp.canceled += instance.OnForceUp;
                }
            }
        }
        public RocketActions @Rocket => new RocketActions(this);
        public interface IRocketActions
        {
            void OnForceUp(InputAction.CallbackContext context);
        }
    }
}
