using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public string nameAnimal;
    public Sprite animalSprite;
    public int letterNumber;
    public GameObject[] lettersToComplete;
    public GameObject[] lettersAnimal;
    public AudioClip audioAnimal;

    public Animal(Sprite animalSprite, int letterNumber, GameObject[] lettersToComplete, GameObject[] lettersAnimal, string nameAnimal, AudioClip audioAnimal)
    {
        this.animalSprite = animalSprite;
        this.letterNumber = letterNumber;
        this.lettersToComplete = lettersToComplete;
        this.lettersAnimal = lettersAnimal;
        this.nameAnimal = nameAnimal;
        this.audioAnimal = audioAnimal;
    }
    //GETTERS
    public Sprite GetAnimalSprite()
    {
        return this.animalSprite;
    }
    public int GetLetterNumber()
    {
        return this.letterNumber;
    }
    public GameObject[] GetLettersToComplete()
    {
        return this.lettersToComplete;
    }
    public GameObject[] GetLettersAnimal()
    {
        return this.lettersAnimal;
    }
    public string GetAnimalName()
    {
        return this.nameAnimal;
    }
    //SETTERS
    public void SetAnimalSprite(Sprite animalSprite)
    {
        this.animalSprite = animalSprite;
    }
    public void SetLetterNumber(int letterNumber)
    {
        this.letterNumber = letterNumber;
    }
    public void SetLettersToComplete(GameObject[] lettersToComplete)
    {
        this.lettersToComplete = lettersToComplete;
    }
    public void SetLettersAnimal(GameObject[] lettersAnimal)
    {
        this.lettersAnimal = lettersAnimal;
    }
    public void SetAnimalName(string nameAnimal)
    {
        this.nameAnimal = nameAnimal;
    }
    public AudioClip GetAnimalSound()
    {
        return audioAnimal;
    }
}
