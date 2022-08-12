using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnCamera : MonoBehaviour
{
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();

        StartCoroutine(CameraAnim());
    }

    IEnumerator CameraAnim()
    {
        yield return new WaitForSeconds(2f);
        anim.SetTrigger("Turn");
    }
}
