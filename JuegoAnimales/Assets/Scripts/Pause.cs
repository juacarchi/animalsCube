using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pause : MonoBehaviour
{
    public GameObject pauseCanvas;
    string url = "https://iquick.es";
    void Start()
    {
        pauseCanvas.SetActive(false);
    }

    void Update()
    {
        
    }
    public void OpenPause()
    {
        pauseCanvas.SetActive(true);
    }
    public void ReturnMenu()
    {
        GameManager.instance.SetLetrasCorrectas(0);
        SceneManager.LoadScene(0);
    }
    public void CloseGame()
    {
        Application.Quit();
    }
    public void OpenURL()
    {
        Application.OpenURL(url);
    }
}
