using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
[RequireComponent(typeof(BoxCollider))]
class Key: MonoBehaviour
{
    [SerializeField]GameObject cerrojo;
    private void Start()
    {
        GetComponent<BoxCollider>().isTrigger = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == cerrojo.name)
        {
            Debug.Log("Cerrojo colicionado");
            //sonido de cerrojo
            Destroy(gameObject,1);
        }  
    }
}
