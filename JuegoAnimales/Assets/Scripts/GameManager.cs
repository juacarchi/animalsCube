using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List <GameObject> animalsList;
    List<GameObject> principalAnimalsList;
    public static GameManager instance;
    int letrasCorrectas;
    int limiteLetras;
    public GameObject fx_Stars;
    public GameObject fx_Succes;
    int levelsCompleted;
    bool levelComplete;
    float timer = 1.5f;
    bool timerToEnd;
    int numberOfAnimal;
    bool allLevelsCompleted;
    int lastAnimal;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            principalAnimalsList = new List<GameObject>(animalsList);
        }
        else
        {
            Destroy(this.gameObject);
        }
       
    }
    
    private void Update()
    {
        if (letrasCorrectas == limiteLetras && limiteLetras != 0)
        {
            Debug.Log("Has ganado");
            if (levelsCompleted != 4)
            {
                InstantiateSuccesFX();
                
            }
            else
            {
                timerToEnd = true;
                letrasCorrectas = 0;
                allLevelsCompleted = true;
            }
            
        }
        if (timerToEnd)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                SumaNivel();
                timer = 1.5f;
                timerToEnd = false;
            }
        }

    }
    public void StartAnimation(Animator anim)
    {
        anim.SetTrigger("Walk");
    }
    public void InstantiateSuccesFX()
    {
        Instantiate(fx_Succes, transform.position, transform.rotation);
        SFX2Manager.instance.PlaySFX(SFX2Manager.instance.victory);
        letrasCorrectas = 0;
        timerToEnd = true;

    }
    public void SumaLetraCorrecta()
    {
        letrasCorrectas += 1;
        Debug.Log(letrasCorrectas);
    }
    public int GetLetrasCorrectas()
    {
        return letrasCorrectas;
    }
    public void SetLetrasCorrectas(int letrasCorrectas)
    {
        this.letrasCorrectas = letrasCorrectas;
    }
    public int GetLimiteLetras()
    {
        return limiteLetras;
    }
    public void SetLimiteLetras(int limiteLetras)
    {
        this.limiteLetras = limiteLetras;
    }
    public void SetLevelsCompleted(int levelsCompleted)
    {
        this.levelsCompleted = levelsCompleted;
    }
    public int GetLevelsCompleted()
    {
        return levelsCompleted;
    }

    public void SetLevelComplete(bool levelComplete)
    {
        this.levelComplete = levelComplete;
    }
    public bool GetLevelComplete()
    {
        return levelComplete;
    }
    public void SumaNivel()
    {
        levelsCompleted++;
        SetLevelComplete(true);
    }
    public List<GameObject> GetAnimalList()
    {
        return animalsList;
    }
    public void SetAnimalList(List<GameObject> animalsList)
    {
        this.animalsList = animalsList;
    }
    public int GetNumberOfAnimal()
    {
        return numberOfAnimal;
    }
    public void SetNumberOfAnimal(int numberOfAnimal)
    {
        this.numberOfAnimal = numberOfAnimal;
    }
    public void ResetListAnimals()
    {
        animalsList = principalAnimalsList;
    }
    public bool GetAllLevelsCompleted()
    {
        return allLevelsCompleted;
    }
    public void ResetAllLevelsCompleted(bool allLevelsCompleted)
    {
        this.allLevelsCompleted = allLevelsCompleted;
    }
    public void SetLastAnimal(int lastAnimal)
    {
        this.lastAnimal = lastAnimal;
    }
    public int GetLastAnimal()
    {
        return lastAnimal;
    }
}
