using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeCubeInt : MonoBehaviour
{

[SerializeField]private GameObject _cubeDedans;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

private void OnCollisionEnter(Collision other){

    if(other.gameObject.CompareTag("Sol")){

_cubeDedans.SetActive(true);
}
    if(other.gameObject.CompareTag("DPlayer")){

Destroy(gameObject);

    }
}



}
