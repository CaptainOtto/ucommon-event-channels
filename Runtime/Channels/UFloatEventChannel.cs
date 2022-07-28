using UnityEngine;
using UnityEngine.Events;

namespace UCommon.EventChannels
{
    /// <summary>
	/// Base class for Event channels of type float.
	/// Implements the <see cref="IEventChannel"/> interface.
	/// </summary>
    [CreateAssetMenu(menuName = "UCommonEvents/OneParam/Float Event Channel")]
    public class UFloatEventChannel : UEventChannel<float> { }
}