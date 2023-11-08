using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Player //INHERITANCE
{
    private void Start()
    {
        jump = 150;
        speed = 1;
        
    }

    private void Update()
    {
        Salto();        
        Movimiento();       //ABSTRACTION
        Muerte();
    }

    public override void Muerte() //POLYMORPHISM
    {
        particulas.transform.position = gameObject.transform.position;
        base.Muerte();

    }

    public override void Salto() //POLYMORPHISM
    {
        base.Salto();
        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.DOShakeScale(1f, .6f,8,10);
        }
        
    }
}
