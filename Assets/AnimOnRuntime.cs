// This script example shows how SetCurve() can be used
using UnityEngine;
using System.Collections;

public class AnimOnRuntime : MonoBehaviour
{
    // Animate the position and color of the GameObject
    public void Start()
    {
    }

    public void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            if (!GetComponent<Animation>().isPlaying)
            GetComponent<Animation>().Play();
        }

    }
}