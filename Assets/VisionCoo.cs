using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionCoo : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("XR Origin"))
        {
            Debug.Log("colicion con player");
        }
    }
}
