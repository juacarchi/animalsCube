using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameplayManagerDef : MonoBehaviour
{
    public RectTransform[] posSpaceToComplete;
    public RectTransform[] posCubeLetters;
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
    
    void Start()
    {
        animalsList = GameManager.instance.GetAnimalList();
        RandomAnimal();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RandomAnimal()
    {
        int backgroundNumber = Random.Range(0, spriteBackground.Length);
        //imageFondo.sprite = spriteBackground[backgroundNumber];
        n_animal = Random.Range(0, animalsList.Count);
        GameManager.instance.SetNumberOfAnimal(n_animal);

        newAnimal = animalsList[n_animal].GetComponent<Animal>();
        GameManager.instance.SetLimiteLetras(newAnimal.GetLetterNumber());
        animalSprite = newAnimal.GetAnimalSprite();
        lettersToComplete = newAnimal.GetLettersToComplete();
        cubeLetters = newAnimal.GetLettersAnimal();

        for (int i = 0; i < cubeLetters.Length; i++)
        {
            GameObject cubeToComplete = Instantiate(cubeLetters[i], posCubeLetters[i].anchoredPosition, Quaternion.identity);
            BoxCollider2D bx = cubeToComplete.GetComponent<BoxCollider2D>();
            bx.enabled = false;
            cubeToComplete.transform.SetParent(posCubeLetters[i].transform);
            RectTransform rect = cubeToComplete.GetComponent<RectTransform>();
            rect.anchoredPosition = new Vector2(0,0);
            bx.enabled = true;
        }

        animalImage.sprite = animalSprite;

    }
}
