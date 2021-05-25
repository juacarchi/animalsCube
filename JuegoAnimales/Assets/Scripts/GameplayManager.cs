using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayManager : MonoBehaviour
{
    public GridLayoutGroup gridLayout;
    public Transform parentPanel;
    public GameObject[] posLettersToComplete;
    public GameObject[] posLettersGrid;
    public GameObject panelVictory;

    public SpriteRenderer animalImage;
    public Sprite[] spriteBackground;

    public Image imageFondo;
    GameObject[] lettersToComplete;
    GameObject[] cubeLetters;
    Sprite animalSprite;
    Animal newAnimal;
    List<GameObject> animalsList;

    int n_animal;
    private void Start()
    {
        panelVictory.SetActive(false);
        animalsList = GameManager.instance.GetAnimalList();
        RandomAnimal();


    }
    public void RandomAnimal()
    {
        int backgroundNumber = Random.Range(0, spriteBackground.Length);
        imageFondo.sprite = spriteBackground[backgroundNumber];
        n_animal = Random.Range(0, animalsList.Count);
        GameManager.instance.SetNumberOfAnimal(n_animal);

        newAnimal = animalsList[n_animal].GetComponent<Animal>();
        GameManager.instance.SetLimiteLetras(newAnimal.GetLetterNumber());
        animalSprite = newAnimal.GetAnimalSprite();
        lettersToComplete = newAnimal.GetLettersToComplete();
        cubeLetters = newAnimal.GetLettersAnimal();
        for (int i = 0; i < lettersToComplete.Length; i++)
        {
            GameObject spaceLetter = Instantiate(lettersToComplete[i], posLettersToComplete[i].transform.position, Quaternion.identity) as GameObject;
            spaceLetter.transform.parent = posLettersToComplete[i].transform;
        }
        for (int i = 0; i < cubeLetters.Length; i++)
        {
            GameObject letter = Instantiate(cubeLetters[i], Vector3.zero, Quaternion.identity) as GameObject;
            letter.transform.SetParent(parentPanel);
        }

        animalImage.sprite = animalSprite;
        Debug.Log("CambioImagen");
    }
    private void Update()
    {
        if (GameManager.instance.GetLevelComplete())
        {
            SFXManager.instance.PlaySFX(newAnimal.GetAnimalSound());
            //panelVictory.SetActive(true);
            animalsList.RemoveAt(n_animal);
            GameManager.instance.SetAnimalList(animalsList);
            GameManager.instance.SetLevelComplete(false);
        }
        if (GameManager.instance.GetAllLevelsCompleted())
        {
            panelVictory.SetActive(true);
        }
    }

}
