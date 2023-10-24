using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChange : MonoBehaviour
{
    [Header("Personajes")]
    [SerializeField] private GameObject[] personajes;

    // Update is called once per frame
    void Update()
    {
        CambioPersonaje();
    }

    public void CambioPersonaje()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            personajes[1].SetActive(true);
            personajes[1].transform.position = personajes[0].transform.position;
            personajes[0].SetActive(false);
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            personajes[0].SetActive(true);
            personajes[0].transform.position = personajes[1].transform.position;
            personajes[1].SetActive(false);
        }
    }
}
