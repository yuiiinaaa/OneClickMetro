using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class runButton : MonoBehaviour
{
    public int count = 0;
    const int goal = 25;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(play());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 0 corresponds to the left mouse button
        {
            count++;
        }
    }

    private IEnumerator play(){
        yield return new WaitForSeconds(7f);
        Debug.Log(count);
        if (count < goal){ // don't hit goal
            SceneManager.LoadScene("SceneScare"); 
        }
        else{
            SceneManager.LoadScene("Scene5");
        }
    }
}
