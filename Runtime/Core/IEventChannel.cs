using UnityEngine.Events;

namespace UCommon.EventChannels
{
    /// <summary>
    /// Interface for event channels of type void.
    /// </summary>
    public interface IEventChannel
    {
        void Emit(); // Raises event.
    }

    /// <summary>
    /// Interface for event channels of type void.
    /// </summary>
    public interface IEventChannel<T1>
    {
        void Emit(T1 value); // Raises event.
    }
}
