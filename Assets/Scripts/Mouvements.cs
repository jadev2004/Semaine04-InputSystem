using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Mouvements : MonoBehaviour
{
    
private Rigidbody _rb;
private Vector2 _valeurRecue;
    void Start()
    {
        
_rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        Bouger();
    }

void Bouger(){
float _valeurX = _valeurRecue.x;
float _valeurY = _valeurRecue.y;

_rb.velocity = new Vector3(_valeurX,0,_valeurY);

//_rb.velocity = new Vector2(-1,0);
}

public void OnMove(InputValue value){

   // Debug.Log(value.Get<Vector2>());

  _valeurRecue = value.Get<Vector2>();  
}

}
