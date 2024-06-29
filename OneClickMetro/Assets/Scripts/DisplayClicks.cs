using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DisplayClicks : MonoBehaviour
{
    // Start is called before the first frame update
    public int click = 0;
    static int wrongClick = 0;
    public Text displayText;

    public GameObject scaryMan;
    //private AudioSource myAudioDie;

    void Start(){
        //myAudioDie = GetComponent<AudioSource>();
    }
    void Update(){
        displayText.text = "CLICKS: " + click;

        if(Input.GetMouseButtonDown(0)){
            Debug.Log("Pressed left-click.");
            click++;

        }

        if(click >= 3){
            //Instantiate(scaryMan);
            SceneManager.LoadScene("SceneScare");
        }
            
    }

}
