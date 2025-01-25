using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TRIGGERSOUND : MonoBehaviour
{
    [SerializeField] UnityEvent onTriggerEnter;

    void OnTriggerEnter(Collider other)
    {
        onTriggerEnter.Invoke();
    } 
}
