using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour {


    private float timeLeft = 300000;
    private Vector3 startScale;
    private Collider collided;
    private Color startColor;
    public GameObject teleportToPlace;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().CompareTag("Player"))
        {
            collided = other;
            timeLeft = 2;
        }
    }

    void Start()
    {
        startScale = transform.localScale;
        startColor = gameObject.GetComponent<Renderer>().material.color;

    }
    void Update()
    {
        transform.Rotate(new Vector3(0,0.5f,0));
        timeLeft -= Time.deltaTime;
        if (timeLeft < 2)
        {
            gameObject.GetComponent<Renderer>().material.color -= new Color(0,0,0,0.05f);
            transform.localScale += new Vector3(0.05f, 0.05f, 0.05f);
        }
        if (timeLeft < 0)
        {
            collided.transform.position = teleportToPlace.transform.position + new Vector3(0,2,0);
            transform.localScale = startScale;
            gameObject.GetComponent<Renderer>().material.color = startColor;
            timeLeft = 300000000;
        }
    }
}
