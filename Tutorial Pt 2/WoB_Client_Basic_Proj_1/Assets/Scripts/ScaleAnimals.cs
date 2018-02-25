using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleAnimals : MonoBehaviour {
	public float scaleFactor;
	private Vector3 startScale;
	public float timeToScaleOver;
	private float progressPercentage; // between 0 and 1
	private float timeOffset; // tracks offset from start of program

	// Use this for initialization
	void Start () {
		progressPercentage = 0.0f;
		startScale = transform.localScale;
		timeOffset = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		
		progressPercentage = (Time.time - timeOffset) / timeToScaleOver;
		if (progressPercentage < 1.0f) {
			float deltaFactor = 1.0f + (scaleFactor - 1.0f) * progressPercentage;
			transform.localScale = startScale * deltaFactor;
		}
	}
}
