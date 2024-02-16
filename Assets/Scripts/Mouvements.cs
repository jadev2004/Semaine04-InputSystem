using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvements : MonoBehaviour
{
    
private Rigidbody _rb;

    void Start()
    {
        
_rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        Bouger()
    }

void Bouger(){


}

public void OnMove(){

    Debug.Log("ijdajdaidj");
}

}
