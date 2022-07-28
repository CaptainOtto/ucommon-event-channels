using UnityEngine;
using UCommon.EventChannels;

namespace UCommon.EventChannels.Samples
{
    public class OneParamReceiver : MonoBehaviour
    {
        [SerializeField] private UIntEventChannel intEvent = default;
        [SerializeField] private UBoolEventChannel boolEvent = default;
        [SerializeField] private UStringEventChannel stringEvent = default;
        [SerializeField] private UFloatEventChannel floatEvent = default;

        private void OnEnable()
        {
            intEvent.Action += OnReceivedIntEvent;
            boolEvent.Action += OnReceivedBoolEvent;
            stringEvent.Action += OnReceivedStringEvent;
            floatEvent.Action += OnReceivedFloatEvent;
        }

        private void OnDisable()
        {
            intEvent.Action -= OnReceivedIntEvent;
            boolEvent.Action -= OnReceivedBoolEvent;
            stringEvent.Action -= OnReceivedStringEvent;
            floatEvent.Action -= OnReceivedFloatEvent;
        }

        public void OnReceivedIntEvent(int value)
        {
            Debug.Log($"Received Event from: {intEvent.channelName}, value: {value}");
        }

        public void OnReceivedBoolEvent(bool value)
        {
            Debug.Log($"Received Event from: {boolEvent.channelName}, value: {value}");
        }

        public void OnReceivedFloatEvent(float value)
        {
            Debug.Log($"Received Event from: {floatEvent.channelName}, value: {value}");
        }

        public void OnReceivedStringEvent(string value)
        {
            Debug.Log($"Received Event from: {stringEvent.channelName}, value: {value}");
        }
    }
}
