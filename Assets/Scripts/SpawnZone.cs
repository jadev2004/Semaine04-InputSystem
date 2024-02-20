using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZone : MonoBehaviour
{

[SerializeField] private GameObject boitePrefab;

[SerializeField] private Vector3 zoneSize;

[SerializeField] private float repeatTime = 0.5f;


    void Start()
    {
       InvokeRepeating("AddGameObject", 0f, repeatTime); 
    }


    void AddGameObject()
    {
        
GameObject instantiated = Instantiate(boitePrefab);
instantiated.transform.position = new Vector3(

Random.Range(transform.position.x - zoneSize.x / 2, transform.position.x + zoneSize.x / 2),
Random.Range(transform.position.y - zoneSize.y / 2, transform.position.x + zoneSize.y / 2),
Random.Range(transform.position.z - zoneSize.z / 2, transform.position.x + zoneSize.z / 2)

);


    }

void OnDrawGizmos(){

Gizmos.color = Color.red;
Gizmos.DrawWireCube(transform.position, zoneSize);

}
}
