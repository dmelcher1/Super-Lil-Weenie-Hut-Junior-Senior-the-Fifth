using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endscript : MonoBehaviour
{
    // how to automatically create triggers around objects after the first one is interacted with

    public Text directions;
    public string endmessage;
    private string trigger;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

        }
        if (trigger == "Player" && Input.GetButtonDown("Fire1"))
        {

            directions.text = endmessage; // will not replace directions to "the end"
        }
    }
    void OnTriggerEnter(Collider other)

    {
        trigger = other.tag;

    }
}