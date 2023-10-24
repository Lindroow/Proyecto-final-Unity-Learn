using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance { get; private set; }
    public int puntos;
    [SerializeField] private TMP_Text lblPuntos;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        puntos = 0;
    }

    public void SubirPuntos()
    {
        puntos++;
        lblPuntos.text = puntos.ToString();
    }
}
