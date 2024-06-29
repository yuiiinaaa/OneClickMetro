using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class StopTrainButton : MonoBehaviour
{


    public bool correctStop = false;
 

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TimerCoroutine());
   
    }

    IEnumerator TimerCoroutine()
    {
        // Wait for 4 seconds
        yield return new WaitForSeconds(13f);
        
        // After 4 seconds, this line will execute
        Debug.Log("Timer has reached 15 seconds!");
        correctStop = true;

        yield return new WaitForSeconds(4f);
        correctStop = false;
        Debug.Log("Timer has reached 20 seconds!");

        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("SceneScare");
        //update to jump scare
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void Click()
    {
        Debug.Log("clicked");

        if (correctStop == true)
        {
            Debug.Log("SURVIVED");
            //change to start
            SceneManager.LoadScene("SceneSurvive");
        }
        else{
            SceneManager.LoadScene("SceneScare");
        }
    }
}
