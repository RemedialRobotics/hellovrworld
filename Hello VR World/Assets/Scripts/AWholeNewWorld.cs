﻿using UnityEngine;
using System.Collections;

public class AWholeNewWorld : MonoBehaviour {

    public float minHeight = 6f;
    public float maxHeight = 15f;
    // Use this for initialization



    public void OnRayCastHit(Vector3 vector)
    {

        string[] planetPrefabs = new string []{ "Earth", "Pluto", "Neptune", "Venus" };


        int planetIndex = Random.Range(0, 3);

       var newPlanetPrefab=Resources.Load(planetPrefabs[planetIndex]);


        float adjustment = Random.Range(minHeight, maxHeight);
        Vector3 adjustedVector = new Vector3(vector.x,vector.y + adjustment, vector.z );

        
   
        GameObject newPlanet = (GameObject)Instantiate(newPlanetPrefab, adjustedVector, Random.rotation);

        //do something else....

       
    }
}
