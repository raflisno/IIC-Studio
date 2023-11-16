using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{

    [Header("Pengaturan Halaman Menu")]
    public string halaman_selanjutnya;
    void Start()
    {
        PlayerPrefs.SetString("halaman_lanjut", halaman_selanjutnya);
    }

    public void PindahHalaman(string halaman)
    {
        SceneManager.LoadScene(halaman);
    }

    public void Buka_Popup(GameObject gameobject)
    {
        gameobject.SetActive(true);
    }

    public void Tutup_Popup(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }

    public void Keluar_Aplikasi()
    {
        Application.Quit();
    }
}
