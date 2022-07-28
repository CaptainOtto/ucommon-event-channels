using UnityEngine;
using UnityEngine.Events;

namespace UCommon.EventChannels
{
    /// <summary>
	/// Base class for Event channels of type bool.
	/// Implements the <see cref="IEventChannel"/> interface.
	/// </summary>
    [CreateAssetMenu(menuName = "UCommonEvents/OneParam/Bool Event Channel")]
    public class UBoolEventChannel : UEventChannel<bool> { }
}