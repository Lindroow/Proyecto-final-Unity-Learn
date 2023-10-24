using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Player
{
    private void Start()
    {
        jump = 150;
        speed = 1;
        
    }

    private void Update()
    {
        Salto();
        Movimiento();
        Muerte();
    }

    public override void Muerte()
    {
        particulas.transform.position = gameObject.transform.position;
        base.Muerte();

    }

    public override void Salto()
    {
        base.Salto();
        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.DOShakeScale(1f, .6f,8,10);
        }
        
    }
}
