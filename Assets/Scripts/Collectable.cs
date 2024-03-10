using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(0,0, 45f * Time.deltaTime);

    }


    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return; //makes scripts reusable
        Destroy(gameObject);

        GameObject[] Collectables = GameObject.FindGameObjectsWithTag("Collectable");
        if(Collectables.Length-1 <= 0)
        {
            print("Game Over");
        }

    }

}
