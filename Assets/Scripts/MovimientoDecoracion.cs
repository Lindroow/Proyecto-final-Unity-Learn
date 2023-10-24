using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MovimientoDecoracion : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float distancia;
    private float posFinal;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(0.5f, 2f);
        distancia = Random.Range(1f, 5f);
        posFinal = transform.position.y + distancia;
        Movimiento();
    }


    public void Movimiento()
    {

        transform.DOMoveY(posFinal, speed).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
        
    }
}
