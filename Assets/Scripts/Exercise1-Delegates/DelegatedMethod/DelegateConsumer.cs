
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateConsumer : MonoBehaviour
{
    [SerializeField] private string secretData = "this is a secret that I'll only share through delegates >:)";
    
    public delegate void SecretDelegate(string secret);

    public void ConsumeDelegate(SecretDelegate secretDelegate)
    {
        //TODO: Receive a delegate as parameter on this method and consume it. HECHO
        //GiveSecret(secretData);
        //TODO: Try your logic giving it a null and see if it shows a NullPointerException :). HECHO

        if (secretDelegate != null)
        {
            secretDelegate(secretData);
        }
        else
        {
            Debug.Log($"{name}: Received a null delegate.");
        }
    }
}
