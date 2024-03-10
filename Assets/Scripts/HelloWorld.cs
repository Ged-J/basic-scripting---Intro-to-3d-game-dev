using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Hello");

        print("Coroutine is now waiting");
    }

    public IEnumerator Hello ()
    {
        print("Hello World");
        yield return new WaitForSeconds(5f);
        print("Welcome to my game");
        yield break;
    }
}
