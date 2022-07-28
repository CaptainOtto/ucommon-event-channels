using UnityEngine;
using UCommon.EventChannels;

namespace UCommon.EventChannels.Samples
{
    public class VoidReceiver : MonoBehaviour
    {
        [SerializeField] private UEventChannel voidEvent = default;

        private void OnEnable()
        {
            voidEvent.Action += OnReceivedEvent;
        }

        private void OnDisable()
        {
            voidEvent.Action -= OnReceivedEvent;
        }
        
        public void OnReceivedEvent()
        {
            Debug.Log($"Received Event from: {voidEvent.channelName}");
        }
    }
}
