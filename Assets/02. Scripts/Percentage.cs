using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Percentage : MonoBehaviour
{
    public GameObject player;
    public GameObject target;
    public Text scoreText;

    private float startDistance;
    private float currentDistance;

    private void Start()
    {
        this.startDistance = Vector3.Distance(player.transform.position, target.transform.position);
    }

    private void Update()
    {
        this.currentDistance = Vector3.Distance(player.transform.position, target.transform.position);
        float percentage = 1 - (currentDistance / startDistance);
        transform.localScale = new Vector3(percentage, 1f, 1f);

        this.scoreText.text = string.Format("Score: {0}%", Mathf.Round(percentage * 100f));
        Debug.Log("Percentage Completed: " + (percentage));
    }



}
