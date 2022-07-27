using UnityEngine;
using UCommon.EventChannels;

namespace UCommon.EventChannels.Samples
{
    public class VoidReceiver : MonoBehaviour
    {
        [SerializeField] private UVoidEventChannel voidEvent = default;

        private void OnEnable()
        {
            voidEvent.EventAction += OnReceivedEvent;
        }

        private void OnDisable()
        {
            voidEvent.EventAction -= OnReceivedEvent;
        }
        
        public void OnReceivedEvent()
        {
            Debug.Log($"Received Event from: {voidEvent.nameID}");
        }
    }
}
