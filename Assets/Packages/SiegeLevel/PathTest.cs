﻿using UnityEngine;
using System.Collections;

public class PathTest : MonoBehaviour {

    [SerializeField]
    Transform pointA;
    [SerializeField]
    Transform pointB;
    [SerializeField]
    bool Fire = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Fire) {
            Fire = false;
            // ThreadedNavigator.GetPath(pointA.position, pointB.position);
            StartCoroutine(ThreadedNavigator.main.GetPathTest(pointA.position, pointB.position));
        }
	}
}
