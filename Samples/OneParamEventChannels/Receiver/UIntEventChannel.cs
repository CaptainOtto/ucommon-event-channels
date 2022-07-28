using UnityEngine;
using UnityEngine.Events;

namespace UCommon.EventChannels
{
    /// <summary>
	/// Base class for Event channels of type int.
	/// Implements the <see cref="IEventChannel"/> interface.
	/// </summary>
    [CreateAssetMenu(menuName = "UCommonEvents/OneParam/Int Event Channel")]
    public class UIntEventChannel : UEventChannel<int> { }
}