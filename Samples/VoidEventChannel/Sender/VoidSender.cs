using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UCommon.EventChannels;

namespace UCommon.EventChannels.Samples
{
    public class VoidSender : MonoBehaviour
    {
        [SerializeField] private Collider testCollider;
        [SerializeField] private UEventChannel voidEvent;

        private void Update()
        {
            // Very simple check for clicking on object to send event.
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (testCollider.Raycast(ray, out hit, 100))
                {
                    voidEvent.Emit();
                }
            }
        }
    }

}
