using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTiger : MonoBehaviour
{
    public Animator finalWords;
 public void DestroyGO()
    {
        Destroy(this.gameObject);
    }
    public void StartAnimWordFinal()
    {
        Debug.Log("AnimaFinal");
        finalWords.SetTrigger("Animated");
    }
}
