using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Panel : MonoBehaviour
{

    public GameObject ekran_Basla;
    public GameObject ekran_tekrarOyna;
    void Start()
    {
        Time.timeScale = 0;
        ekran_Basla.SetActive(true);
        ekran_tekrarOyna.SetActive(false);
    }

    void Update()
    {
        
    }

    public void Başla()
    {
        ekran_Basla.SetActive(false);
        ekran_tekrarOyna.SetActive(false);
        Time.timeScale = 1;
    }
    public void Tekrar_Oyna()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene("SampleScene");
    }

    public void Bitir()
    {
        Time.timeScale = 0;
        ekran_Basla.SetActive(false);
        ekran_tekrarOyna.SetActive(true);
    }
}
