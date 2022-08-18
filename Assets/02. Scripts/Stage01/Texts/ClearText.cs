using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearText : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();   
        StartCoroutine(Clear());
    }

    public IEnumerator Clear()
    {
        yield return new WaitForSeconds(71f);
        anim.SetTrigger("Clear");
    }
}
