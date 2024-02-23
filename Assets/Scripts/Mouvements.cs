using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Mouvements : MonoBehaviour
{
[SerializeField] float _vitesse = 2;   
private Rigidbody _rb;
private Vector3 _valeurRecue;
private float _valeurX;
private float _valeurY;
private float _valeurZ;
[SerializeField] float _points = 1;  

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


 _rb.velocity = new Vector3(_valeurX*50,_valeurY*_vitesse,_valeurZ*_vitesse);   

//_rb.velocity = new Vector2(-1,0);
}

public void OnMove(InputValue value){

   // Debug.Log(value.Get<Vector2>());

Vector3 _valeurRecue = value.Get<Vector3>();  
 _valeurX = _valeurRecue.x;
 _valeurY = _valeurRecue.y;
_valeurZ = _valeurRecue.z;
}





//private void OnCollisionEnter(Collision other){

    //if(other.gameObject.CompareTag("CubeD")){

//Destroy(other.gameObject);
//}
    
//}

private void OnCollisionEnter(Collision other){
if(other.gameObject.CompareTag("PointPortail"))
_points = other.gameObject.GetComponent<PointsPortail>().nbPoint;
Debug.Log(_points);
Destroy(other.gameObject);
}


}