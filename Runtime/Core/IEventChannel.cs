using UnityEngine.Events;

namespace UCommon.EventChannels
{
    /// <summary>
    /// Interface for event channels of type void.
    /// </summary>
    public interface IEventChannel
    {
        void Trigger(); // Raises event.
    }
}
