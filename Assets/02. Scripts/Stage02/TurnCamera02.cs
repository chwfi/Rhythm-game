using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class TurnCamera02 : MonoBehaviour
{
    Animator anim;
    CinemachineVirtualCamera VC;
    bool canClick = false;
    bool canTurn = true;

    private void Start()
    {
        anim = GetComponent<Animator>();
        VC = GetComponent<CinemachineVirtualCamera>();
        StartCoroutine(CameraAnim());
    }

    IEnumerator CameraAnim()
    {
        yield return new WaitForSeconds(4.65f);
        anim.SetTrigger("Turn01");
        canTurn = false;
        VC.m_Lens.OrthographicSize = 4.5f;
        yield return new WaitForSeconds(9.25f);
        canTurn = true;
        VC.m_Lens.OrthographicSize = 4.5f;


    }

    private void Update()
    {
        if (canTurn == true)
        {
            if (Input.GetKeyDown(KeyCode.Space) && canClick == true || Input.GetMouseButtonDown(0) && canClick == true)
            {
                VC.m_Lens.OrthographicSize = 4.42f;
                canClick = false;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && canClick == false || Input.GetMouseButtonDown(0) && canClick == false)
            {
                VC.m_Lens.OrthographicSize = 4.5f;
                canClick = true;
            }

        }
    }
}
