using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    [SerializeField] private TMP_Text lblPuntos;
    [SerializeField] private TMP_Text lblBestScore;
    [SerializeField] private GameObject panelReinciar;

    

    public void SubirPuntosUI()
    {
        lblPuntos.text = GameManager.instance.puntos.ToString();
    }

    IEnumerator MostrarPanelReinicio()
    {
        yield return new WaitForSeconds(2f);
        Time.timeScale = 0;
        panelReinciar.SetActive(true);
        if (GameManager.instance.puntos > GameManager.instance.BestScore)
        {
            GameManager.instance.BestScore = GameManager.instance.puntos;
        }
        lblBestScore.text = GameManager.instance.BestScore.ToString();

    }

    public void btnJugar()
    {
        Time.timeScale = 1;
        GameManager.instance.puntos = 0;
        SceneManager.LoadScene(1);
    }

    public void VolverMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void btnSalir()
    {
        Application.Quit();
    }
}
