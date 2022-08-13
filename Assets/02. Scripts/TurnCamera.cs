using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class TurnCamera : MonoBehaviour
{
    Animator anim;
    CinemachineVirtualCamera VC;

    private void Start()
    {
        anim = GetComponent<Animator>();
        VC = GetComponent<CinemachineVirtualCamera>();
        StartCoroutine(CameraAnim());
    }

    IEnumerator CameraAnim()
    {
        yield return new WaitForSeconds(7.78f);
        //anim.SetTrigger("Turn");
        yield return new WaitForSeconds(2.45f);        
        anim.SetTrigger("Turn");
        yield return new WaitForSeconds(3.32f);
        VC.m_Lens.OrthographicSize = 3.8f;
        yield return new WaitForSeconds(3.12f);
        VC.m_Lens.OrthographicSize = 5f;
        anim.SetTrigger("Turn2");
        yield return new WaitForSeconds(1.5f);
        VC.m_Lens.OrthographicSize = 3.8f;
        yield return new WaitForSeconds(3.4f);
        VC.m_Lens.OrthographicSize = 5f;
        anim.SetTrigger("Turn3");
        yield return new WaitForSeconds(1.5f);
        VC.m_Lens.OrthographicSize = 3.8f;
        yield return new WaitForSeconds(3.29f);
        VC.m_Lens.OrthographicSize = 5f;
        anim.SetTrigger("Turn2");
        yield return new WaitForSeconds(1.49f);
        VC.m_Lens.OrthographicSize = 3.8f;
        yield return new WaitForSeconds(3.32f);
        VC.m_Lens.OrthographicSize = 5f;
        anim.SetTrigger("Turn3");
        
    }
}
