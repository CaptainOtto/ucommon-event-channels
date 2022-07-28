using UnityEngine;
using UnityEngine.Events;

namespace UCommon.EventChannels
{
    /// <summary>
	/// Base class for Event channels of type void.
	/// Implements the <see cref="IEventChannel"/> interface.
	/// </summary>
    [CreateAssetMenu(menuName = "UCommonEvents/Void Event Channel")]
    public class UEventChannel : ScriptableObject, IEventChannel
    {
        /// <summary>
        /// The name of channel.
        /// </summary>
        public string channelName;

#if UNITY_EDITOR
        /// <summary>
        /// Description for editor reference.
        /// </summary>
        [SerializeField, Multiline] private string description;
#endif
        /// <summary>
        /// Action to be sent.
        /// </summary>
        public UnityAction Action;

        /// <summary>
        /// Emits said channels action.
        /// </summary>
        public void Emit()
        {
            Debug.Log($"Raised event for: {channelName}");
            Action?.Invoke();
        }
    }

    /// <summary>
    /// Base class for Event channels of type void.
    /// Implements the <see cref="IEventChannel"/> interface.
    /// </summary>
    [CreateAssetMenu(menuName = "UCommonEvents/Void Event Channel")]
    public abstract class UEventChannel<T1> : ScriptableObject, IEventChannel<T1>
    {
        /// <summary>
        /// The name of channel.
        /// </summary>
        public string channelName;

#if UNITY_EDITOR
        /// <summary>
        /// Description for editor reference.
        /// </summary>
        [SerializeField, Multiline] private string description;
#endif
        /// <summary>
        /// Action to be sent.
        /// </summary>
        public UnityAction<T1> Action;

        /// <summary>
        /// Emits said channels action.
        /// </summary>
        public void Emit(T1 value)
        {
            Debug.Log($"Raised event for: {channelName}, value: {value}");
            Action?.Invoke(value);
        }
    }
}