using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Zoom : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera virtualCamera;
    [SerializeField] private float speed = 5f;
    private void Start()
    {
        /*StartCoroutine(TurnCam());*/
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            
        }  
    }

    /*private IEnumerator TurnCam()
    {
        //yield return new WaitForSeconds(5.54f);
        //virtualCamera.transform.localEulerAngles = new Vector3(0, 0, 90);
        //yield return new WaitForSeconds(4.85f);
        //virtualCamera.transform.localEulerAngles = new Vector3(0, 0, 0);
        //yield return new WaitForSeconds(3.3f);
        
    }*/



}
