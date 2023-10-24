using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoObstaculo : MonoBehaviour
{
    [SerializeField] private int velocidad;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
    }

    public void Movimiento()
    {
        gameObject.transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        if (transform.position.x >= 30)
        {
            Destroy(gameObject);
        }
    }
}
