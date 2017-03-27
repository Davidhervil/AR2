using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

// Este script se le pone al image target de las marcas de movimiento en el cubo. A cada una se le puede poner
// un nombre o tag distinto y en el codigo de movimiento se chequea la marca que es, y dependiendo de cual sea se
// mueve hacia adelante, derecha, izquierda,etc.
public class CharacterScript : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;
    public GameObject Character;

    // Use this for initialization
    void Start()
    {
        Character = GameObject.FindWithTag("Player");
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        //if (newStatus == TrackableBehaviour.Status.DETECTED ||
        //    newStatus == TrackableBehaviour.Status.TRACKED ||
        //    newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        //{
        //    CODIGO AQUI PARA MOVER EL PERSONAJE CUANDO SE VEA LA MARCA. 
        //    VERIFICAR PRIMERO QUE MARCA ES Y EN BASE A LA MARCA MOVER EN LA DIRECCION CORRECTA.
        //}
        //else
        //{

        //}
    }
}
