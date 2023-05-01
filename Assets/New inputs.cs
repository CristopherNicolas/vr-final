//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.0
//     from Assets/New inputs.inputactions
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

public partial class @Newinputs: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Newinputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""New inputs"",
    ""maps"": [
        {
            ""name"": ""map 1"",
            ""id"": ""93ed0ca6-6b5d-4464-b5cb-68f7f05d49ca"",
            ""actions"": [
                {
                    ""name"": ""triger pressed"",
                    ""type"": ""Button"",
                    ""id"": ""62448cd0-7bef-4edf-ad34-de9f561b786a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9b8d9ce3-dfb3-4dd9-9f34-a7cad44e7d16"",
                    ""path"": ""<ViveController>{RightHand}/triggerPressed"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""triger pressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // map 1
        m_map1 = asset.FindActionMap("map 1", throwIfNotFound: true);
        m_map1_trigerpressed = m_map1.FindAction("triger pressed", throwIfNotFound: true);
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

    // map 1
    private readonly InputActionMap m_map1;
    private List<IMap1Actions> m_Map1ActionsCallbackInterfaces = new List<IMap1Actions>();
    private readonly InputAction m_map1_trigerpressed;
    public struct Map1Actions
    {
        private @Newinputs m_Wrapper;
        public Map1Actions(@Newinputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @trigerpressed => m_Wrapper.m_map1_trigerpressed;
        public InputActionMap Get() { return m_Wrapper.m_map1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Map1Actions set) { return set.Get(); }
        public void AddCallbacks(IMap1Actions instance)
        {
            if (instance == null || m_Wrapper.m_Map1ActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_Map1ActionsCallbackInterfaces.Add(instance);
            @trigerpressed.started += instance.OnTrigerpressed;
            @trigerpressed.performed += instance.OnTrigerpressed;
            @trigerpressed.canceled += instance.OnTrigerpressed;
        }

        private void UnregisterCallbacks(IMap1Actions instance)
        {
            @trigerpressed.started -= instance.OnTrigerpressed;
            @trigerpressed.performed -= instance.OnTrigerpressed;
            @trigerpressed.canceled -= instance.OnTrigerpressed;
        }

        public void RemoveCallbacks(IMap1Actions instance)
        {
            if (m_Wrapper.m_Map1ActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMap1Actions instance)
        {
            foreach (var item in m_Wrapper.m_Map1ActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_Map1ActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public Map1Actions @map1 => new Map1Actions(this);
    public interface IMap1Actions
    {
        void OnTrigerpressed(InputAction.CallbackContext context);
    }
}
