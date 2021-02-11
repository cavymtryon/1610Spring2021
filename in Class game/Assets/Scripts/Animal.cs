using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    // Start is called before the first frame update
    public Color animalColor = Color.red;
    public float speed = 1.0f;
    public string animalName = "Bob";
    public int health = 10;

    private void Start()
    {
        Debug.Log(message: " Hello World.");

    }
}


