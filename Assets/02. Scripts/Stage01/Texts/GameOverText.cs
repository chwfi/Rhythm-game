using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverText : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        gameObject.SetActive(false);
        anim = GetComponent<Animator>();
    }
    
}
