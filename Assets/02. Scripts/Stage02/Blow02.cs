using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blow02 : MonoBehaviour
{
    Animator anim;
    bool canBlow = true;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        StartCoroutine(End());
    }
    private IEnumerator End()
    {
        yield return new WaitForSeconds(139f);
        canBlow = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canBlow == true || Input.GetMouseButtonDown(0) && canBlow == true)
        {
            anim.SetTrigger("Blow");
        }
    }
}
