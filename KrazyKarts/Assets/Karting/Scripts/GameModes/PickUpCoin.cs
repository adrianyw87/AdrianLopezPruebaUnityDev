using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCoin : TargetObject
{
    public static event Action coinCollectedEvent = delegate { };

    public float rotationVelocity = 100f;

    void OnCollect()
    {
        if (CollectSound)
        {
            AudioUtility.CreateSFX(CollectSound, transform.position, AudioUtility.AudioGroups.Pickup, 0f);
        }

        coinCollectedEvent();

        Destroy(gameObject);
    }

    private void Update()
    {
        transform.Rotate(Vector3.back * rotationVelocity * Time.deltaTime, Space.Self);
    }

    void OnTriggerEnter(Collider other)
    {
        if ((layerMask.value & 1 << other.gameObject.layer) > 0 && other.gameObject.CompareTag("Player"))
        {
            OnCollect();            
        }
    }
}