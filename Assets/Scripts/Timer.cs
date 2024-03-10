using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public float totalTime= 10f;


    // Start is called before the first frame update
    void Start()
    {

        Invoke("restartLevel" , totalTime);

    }

    public void restartLevel()
    {

        SceneManager.LoadScene("CubeCollecter");

        print("Restart Level");
    }
    
}
