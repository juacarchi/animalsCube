using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameplayManagerDef : MonoBehaviour
{
    public RectTransform[] posSpaceToComplete;
    public RectTransform[] posCubeLetters;
    public GameObject panelVictory;
    public GameObject canvasVictory;
    public GameObject canvasFinalVictory;
    public SpriteRenderer animalImage;
    public Sprite[] spriteBackground;

    public Image imageFondo;
    GameObject[] lettersToComplete;
    GameObject[] cubeLetters;
    Sprite animalSprite;
    Animal newAnimal;
    List<GameObject> animalsList;

    int n_animal;
    private void Awake()
    {
        canvasVictory.SetActive(false);
        canvasFinalVictory.SetActive(false);
    }
    void Start()
    {
        
        animalsList = GameManager.instance.GetAnimalList();
        RandomAnimal();
    }

    public void RandomAnimal()
    {
        int backgroundNumber = Random.Range(0, spriteBackground.Length);
        //imageFondo.sprite = spriteBackground[backgroundNumber]
        do
        {
            n_animal = Random.Range(0, animalsList.Count);
        } while (n_animal == GameManager.instance.GetLastAnimal());
        
        GameManager.instance.SetNumberOfAnimal(n_animal);
        GameManager.instance.SetLastAnimal(n_animal);

        newAnimal = animalsList[n_animal].GetComponent<Animal>();
        GameManager.instance.SetLimiteLetras(newAnimal.GetLetterNumber());
        animalSprite = newAnimal.GetAnimalSprite();
        lettersToComplete = newAnimal.GetLettersToComplete();
        cubeLetters = newAnimal.GetLettersAnimal();
        Debug.Log(newAnimal.GetAnimalName());

        for (int i = 0; i < cubeLetters.Length; i++)
        {
            GameObject cubeToComplete = Instantiate(cubeLetters[i], posCubeLetters[i].anchoredPosition, Quaternion.identity);
            cubeToComplete.transform.SetParent(posCubeLetters[i].transform);
            RectTransform rect = cubeToComplete.GetComponent<RectTransform>();
            rect.anchoredPosition = Vector2.zero;
        }
        for (int i = 0; i < lettersToComplete.Length; i++)
        {
            GameObject letter = Instantiate(lettersToComplete[i], posSpaceToComplete[i].anchoredPosition, Quaternion.identity) as GameObject;
            letter.transform.SetParent(posSpaceToComplete[i].transform);
            RectTransform rect = letter.GetComponent<RectTransform>();
            rect.anchoredPosition = Vector2.zero;
        }

        animalImage.sprite = animalSprite;

    }
    private void Update()
    {
        if (GameManager.instance.GetLevelComplete())
        {
            SFXManager.instance.PlaySFX(newAnimal.GetAnimalSound());
            //panelVictory.SetActive(true);
            canvasVictory.SetActive(true);
            animalsList.RemoveAt(n_animal);
            GameManager.instance.SetAnimalList(animalsList);
            GameManager.instance.SetLevelComplete(false);
        }
        if (GameManager.instance.GetAllLevelsCompleted())
        {
            canvasFinalVictory.SetActive(true);
            canvasVictory.SetActive(false);

        }
    }

    public void Restart()
    {
        GameManager.instance.SetLetrasCorrectas(0);
        SceneManager.LoadScene(2);
    }

}
