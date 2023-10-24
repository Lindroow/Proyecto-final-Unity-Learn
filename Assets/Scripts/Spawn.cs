using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject[] obstaculos;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnObstaculo");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnObstaculo()
    {
        yield return new WaitForSeconds(Random.Range(2, 4));
        Instantiate(obstaculos[Random.Range(0,obstaculos.Length)], gameObject.transform);
        StartCoroutine("SpawnObstaculo");
    }
}
