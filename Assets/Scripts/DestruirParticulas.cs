using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirParticulas : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject,3);
    }
}
