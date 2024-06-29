using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static int clicks = 0;
    // Start is called before the first frame update
   public static GameManager Instance;
	void Awake(){
		if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
	}

    void Start(){
       // myAudioDie = GetComponent<AudioSource>();
    }

	/// <summary>
	/// This GameManager will check for input to restart the scene
	/// </summary>
	void Update(){
		if (Input.GetKeyDown (KeyCode.Escape) || Input.GetKeyDown (KeyCode.R) || Input.GetKeyDown (KeyCode.Return)) {
			RestartTheGame ();
		}
	}
		
	/// <summary>
	/// Reloads the current scene.
	/// </summary>
	public void RestartTheGame(){
        //myAudioDie.Play();
		//SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
        
	}
}
