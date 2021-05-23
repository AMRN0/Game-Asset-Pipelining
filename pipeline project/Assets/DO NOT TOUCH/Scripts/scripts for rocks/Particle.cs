using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//applied to the particle system to stop from continuously spawning.
public class Particle : MonoBehaviour {

    //setting the variables.
    private float StartTime, duration = 2.0f;

	// Use this for initialization
	void Start ()
    {
        //sets thye variable start time as the current time.
        StartTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {

        //if current time minus the start time is more than the duration of 1 float.
        if (Time.time - StartTime > duration)
        {
            //destroy this game object.
            Destroy(this.gameObject);

        }
		
	}
}
