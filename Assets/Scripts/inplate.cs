using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class inplate : MonoBehaviour
{

    public GameObject target1;
    public GameObject target2;
    public void EndGame()
    {
        Transform tf1 = target1.GetComponent<Transform>();
        Transform tf2 = target2.GetComponent<Transform>();
        float r = 10f;
        if (tf1.position.x < tf2.position.x + r && tf1.position.x > tf2.position.x - r && tf1.position.z < tf2.position.z + r && tf1.position.z > tf2.position.z - r)
        {
            Debug.Log("!!!!!!!!!!");
            UnityEditor.EditorApplication.isPlaying = false;
            //Application.Quit();
            SceneManager.LoadScene(0);

        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform tf1 = target1.GetComponent<Transform>();
        Transform tf2 = target2.GetComponent<Transform>();
        float r = 0.7f;
        if (tf1.position.x < tf2.position.x + r && tf1.position.x > tf2.position.x - r && tf1.position.z < tf2.position.z + r && tf1.position.z > tf2.position.z - r)
        {
            Debug.Log("!!!!!!!!!!");
            UnityEditor.EditorApplication.isPlaying = false;
            //Application.Quit();
            SceneManager.LoadScene(0);

        }
    }
}
