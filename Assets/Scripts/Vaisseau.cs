using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Vaisseau : MonoBehaviour
{
    // Start is called before the first frame update

private float _valeurX;
private float _valeurY;
private Vector2 _mouvementHorizontal;
private Rigidbody _rb;


    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update(){
       Bouge();

    }


    public void GaucheDroite(InputAction.CallbackContext context){

       // Debug.Log(context.ReadValue<Vector2>());
       _mouvementHorizontal= context.ReadValue<Vector2>();
       _valeurX = _mouvementHorizontal.x;
       _valeurY = _mouvementHorizontal.y;
    }

   public void Bouge(){
 Vector2 _mouvement = new Vector2 (_valeurX,_valeurY);
        _rb.AddForce(_mouvement*40,ForceMode.Force);

    }

}
