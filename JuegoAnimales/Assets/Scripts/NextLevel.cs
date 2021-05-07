using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class NextLevel : MonoBehaviour
{
    public Button btn_1;
    public Button btn_2;
    public Button btn_3;
    public Button btn_4;
    public Button btn_5;

    private void Start()
    {
        if (GameManager.instance.GetLevelsCompleted() == 0)
        {
            btn_1.interactable = true;
            btn_2.interactable = false;
            btn_3.interactable = false;
            btn_4.interactable = false;
            btn_5.interactable = false;
        }
        else if (GameManager.instance.GetLevelsCompleted() == 1)
        {
            btn_1.interactable = false;
            btn_2.interactable = true;
            btn_3.interactable = false;
            btn_4.interactable = false;
            btn_5.interactable = false;
        }
        else if (GameManager.instance.GetLevelsCompleted() == 2)
        {
            btn_1.interactable = false;
            btn_2.interactable = false;
            btn_3.interactable = true;
            btn_4.interactable = false;
            btn_5.interactable = false;
        }
        else if (GameManager.instance.GetLevelsCompleted() == 3)
        {
            btn_1.interactable = false;
            btn_2.interactable = false;
            btn_3.interactable = false;
            btn_4.interactable = true;
            btn_5.interactable = false;
        }
        else if (GameManager.instance.GetLevelsCompleted() == 4)
        {
            btn_1.interactable = false;
            btn_2.interactable = false;
            btn_3.interactable = false;
            btn_4.interactable = false;
            btn_5.interactable = true;
        }
    }
    public void StartChangeScene()
    {
        UITransition.instance.StartRightAnimation();
        StartCoroutine("ChangeScene");
    }
    public void NextFase()
    {
        SceneManager.LoadScene(2);
    }
    public IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(2.0f);
        NextFase();
        
    }
}
