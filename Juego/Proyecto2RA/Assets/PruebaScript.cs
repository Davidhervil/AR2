using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class PruebaScript : MonoBehaviour, ITrackableEventHandler
{
    //private TrackableBehaviour mTrackableBehaviour;
    //public GameObject Cubo;
    // Use this for initialization
    void Start () {
        //Cubo = GameObject.FindWithTag("Player");
        //mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        //if (mTrackableBehaviour)
        //{
        //    mTrackableBehaviour.RegisterTrackableEventHandler(this);
        //}
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        //if (newStatus == TrackableBehaviour.Status.DETECTED ||
        //    newStatus == TrackableBehaviour.Status.TRACKED ||
        //    newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        //{
        //    Cubo.GetComponent<Renderer>().material.color = Color.blue;
        //}
        //else
        //{

        //}
    }
}
