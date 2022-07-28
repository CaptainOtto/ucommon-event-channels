using UnityEngine;
using UnityEngine.Events;

namespace UCommon.EventChannels
{
    /// <summary>
	/// Base class for Event channels of type string.
	/// Implements the <see cref="IEventChannel"/> interface.
	/// </summary>
    [CreateAssetMenu(menuName = "UCommonEvents/OneParam/String Event Channel")]
    public class UStringEventChannel : UEventChannel<string> { }
}