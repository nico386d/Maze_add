using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class youWon : MonoBehaviour
{

    // Start is called before the first frame update
    
    void Start()
    {

        GameObject points = GameObject.FindGameObjectWithTag("Point");
    }

    // Update is called once per frame
    void Update()
    {
        
        GameObject points = GameObject.FindGameObjectWithTag("Point");
        if (points == null)
        {
            Debug.Log("it works");
            MazeInfo.mazeInfo = null;
            SceneManager.LoadScene("You won");
        }
    }
}
