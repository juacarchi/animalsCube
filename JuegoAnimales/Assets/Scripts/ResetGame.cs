using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetGame : MonoBehaviour
{
  public void ResetVideoGame()
    {
        GameManager.instance.ResetAllLevelsCompleted(false);
        GameManager.instance.ResetListAnimals();
        GameManager.instance.SetLevelsCompleted(0);
        UITransition.instance.StartLeftAnimation();
    }
}
