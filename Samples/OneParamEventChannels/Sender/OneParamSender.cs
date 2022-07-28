using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UCommon.EventChannels;

namespace UCommon.EventChannels.Samples
{
    public class OneParamSender : MonoBehaviour
    {
        [SerializeField] private Collider testCollider;

        [Header("Int Channel")]
        [SerializeField] private bool shouldEmitOnIntChannel = false;
        [SerializeField] private int intChannelValue = 0;
        [SerializeField] private UIntEventChannel intChannel;

        [Header("Float Channel")]
        [SerializeField] private bool shouldEmitOnFloatChannel = false;
        [SerializeField] private float floatChannelValue = 0.0f;
        [SerializeField] private UFloatEventChannel floatChannel;

        [Header("String Channel")]
        [SerializeField] private bool shouldEmitOnStringChannel = false;
        [SerializeField] private string stringChannelValue = "";
        [SerializeField] private UStringEventChannel stringChannel;

        [Header("Bool Channel")]
        [SerializeField] private bool shouldEmitOnBoolChannel = false;
        [SerializeField] private bool boolChannelValue = false;
        [SerializeField] private UBoolEventChannel boolChannel;

        private void Update()
        {
            // Very simple check for clicking on object to send event.
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (testCollider.Raycast(ray, out hit, 100))
                {
                    if(shouldEmitOnIntChannel)
                    {
                        intChannel.Emit(intChannelValue);
                    }

                    if (shouldEmitOnFloatChannel)
                    {
                        floatChannel.Emit(floatChannelValue);
                    }

                    if (shouldEmitOnStringChannel)
                    {
                        stringChannel.Emit(stringChannelValue);
                    }

                    if (shouldEmitOnBoolChannel)
                    {
                        boolChannel.Emit(boolChannelValue);
                    }
                }
            }
        }
    }

}
