using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Player
{
    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
        jump = 50;
    }

    // Update is called once per frame
    void Update()
    {
        Salto();
        Movimiento();
        Muerte();
    }
}
