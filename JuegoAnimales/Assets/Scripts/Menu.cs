using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayGame()
    {
        UITransition.instance.StartLeftAnimation();
        //SceneManager.LoadScene(1); //CUANDO HAYA MÁS ANIMALES CAMBIAR POR RANDOMRANGE
    }
}
