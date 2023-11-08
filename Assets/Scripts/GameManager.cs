using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{

    public static GameManager instance { get; private set; }
    public int puntos;
    public int BestScore;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
            instance = this;
            DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        puntos = 0;
    }

    public void SubirPuntos()
    {
        puntos++;
    }

    

    



}
