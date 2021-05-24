using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayManager : MonoBehaviour
{
    public GridLayoutGroup gridLayout;
    public Transform parentPanel;
    public RectTransform[] posLettersToComplete;
    public RectTransform[] posLettersGrid;
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
            GameObject spaceLetter = Instantiate(lettersToComplete[i], posLettersToComplete[i].anchoredPosition, Quaternion.identity);
            spaceLetter.transform.parent = posLettersToComplete[i].transform;
            spaceLetter.transform.localScale = new Vector3(1, 1, 1);
        }
        for (int i = 0; i < cubeLetters.Length; i++)
        {
            GameObject letter = Instantiate(cubeLetters[i], posLettersGrid[i].anchoredPosition, Quaternion.identity);
            letter.transform.SetParent(parentPanel);
            letter.transform.localScale = new Vector3(1, 1, 1);
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
