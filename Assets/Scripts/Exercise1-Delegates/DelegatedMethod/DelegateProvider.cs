using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DelegateConsumer;

public class DelegateProvider : MonoBehaviour
{
    [SerializeField] private DelegateConsumer consumer;

    private SecretDelegate secretDelegate;

    private void GiveSecret(string secret)
    {
        Debug.Log($"Received secret: {secret}");
    }

    private void Start()
    {
        secretDelegate = GiveSecret;
    }

    [ContextMenu("Test logic consumption")]
    private void TestLogicConsumption()
    {
        //TODO: Add the parameter here to handle the secret. HECHO
        //You can log the value to test it :)
        consumer.ConsumeDelegate(secretDelegate);
        consumer.ConsumeDelegate(null);
    }
}
