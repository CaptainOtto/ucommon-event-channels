using UnityEngine;
using UnityEngine.Events;

namespace UCommon.EventChannels
{
    /// <summary>
	/// Base class for Event channels of type void.
	/// Implements the <see cref="IEventChannel"/> interface.
	/// </summary>
    [CreateAssetMenu(menuName = "UCommonEvents/Void Event Channel")]
    public class UVoidEventChannel : ScriptableObject, IEventChannel
    {
        public string nameID;
#if UNITY_EDITOR
        [SerializeField, Multiline] private string description;
#endif
        public UnityAction EventAction;

        public void Trigger()
        {
            Debug.Log($"Raised event for: {nameID}");
            EventAction?.Invoke();
        }
    }
}