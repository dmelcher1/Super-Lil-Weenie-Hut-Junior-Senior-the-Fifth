using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyScript : MonoBehaviour {
    Transform key;
    int max = 1;
    int maxPos = 1;
    int minPos = -28;
    Vector3 newPos;
     bool touched = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		for (int i=0;i<max;i++)
        {
            spawn();

        }
	}

    void spawn()
    {
        newPos = new Vector3(Random.Range(minPos, maxPos), 0, Random.Range(minPos, maxPos));
        Instantiate(key, newPos, transform.rotation);

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            other.gameObject.SetActive(true);
            
        }
    }
}
