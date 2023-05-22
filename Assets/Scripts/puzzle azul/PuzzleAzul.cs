using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Threading.Tasks;

public class PuzzleAzul : MonoBehaviour
{
    bool estaSiendoApuntado;
    [SerializeField] Vector3 direccion,startPos;
    [SerializeField] float tiempo;
    private void Awake()
    {
        startPos = transform.position;
    }
    private async void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<ColicionLinterna>() && !estaSiendoApuntado && other.transform.parent.GetComponent<Linterna>().tipolINTERNA == TIPOLINTERNA.TipoLinternaAzul)
        {
           estaSiendoApuntado = true;
            await Task.Delay(1000);
            if (!estaSiendoApuntado) return;
            transform.DOMove(new Vector3(startPos.x+direccion.x,startPos.y+direccion.y,startPos.z+direccion.z), tiempo);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<ColicionLinterna>())
        {
            estaSiendoApuntado = false;
        }
    }

}
