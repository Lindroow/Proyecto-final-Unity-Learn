using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Propiedades")]
    [SerializeField] private int _jump;
    [SerializeField] private int _speed;
    [SerializeField] private int puntos;
    
    [SerializeField] private Rigidbody rb;
    [SerializeField] private ParticleSystem _particulas;

    public int jump
    {
        protected set { _jump = value; }
        get { return _jump; }
    }
    public int speed
    {
        protected set { _speed = value; }
        get { return _speed; }

    }public ParticleSystem particulas
    {
        protected set { _particulas = value; }
        get { return _particulas; }
    }


    public virtual void Salto()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0, _jump, 0);
        }
    }

    public virtual void Movimiento()
    {
        float Z = Input.GetAxis("Horizontal") * _speed * Time.deltaTime;

        transform.Translate(0, 0, Z);

        if (transform.position.z >= 1.1f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 1.1f);
        }
        else if (transform.position.z <= -1.1f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -1.1f);
        }
    }

    public virtual void Muerte()
    {
        if (transform.position.x >= 3.80f)
        {
            Destroy(transform.parent.gameObject);
            particulas.Play();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            GameManager.instance.SubirPuntos();
        }
    }
}
