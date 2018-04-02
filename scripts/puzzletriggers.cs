using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puzzletriggers : MonoBehaviour
{

    public Text directions;
    public string message;
    private string trigger;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
        }
        if (trigger == "Player" && Input.GetButtonDown("Fire1"))
        {
            directions.text = message;
        }
    }
    void OnTriggerEnter(Collider other)

    {
        trigger = other.tag;

    }
}

   