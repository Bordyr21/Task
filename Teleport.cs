using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportPoint = null;

    void OnTriggerEnter(Collider other)
    {   
        other.GetComponent<Transform>().position = teleportPoint.position;

    }
}
