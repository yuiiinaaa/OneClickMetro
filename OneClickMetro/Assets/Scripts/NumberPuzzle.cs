using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumberPuzzle : MonoBehaviour
{
    private int currentButtonIndex = 0;
    // Start is called before the first frame update
    public GameObject[] buttons;
    void Start()
    {
        currentButtonIndex = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClicked(int buttonValue)
    {
        // Check if the buttons are clicked in the specific order "4013"
        if (buttonValue == int.Parse("4013"[currentButtonIndex].ToString()))
        {
            // Correct button clicked, move to the next in the sequence
            currentButtonIndex++;

            // Check if the entire sequence is completed
            if (currentButtonIndex == 4)
            {
                
                Debug.Log("Button sequence completed!");
                
                SceneManager.LoadScene("Scene2.1");
                // Additional actions for completing the sequence can be added here
            }
        }
        else
        {
            // Incorrect button clicked, reset the sequence
            currentButtonIndex = 0;
            Debug.Log("Incorrect button clicked. Resetting sequence.");
        }
    }

        public void hide()
    {
        // Hide the game object and delete it
        foreach (var button in buttons)
        {
            button.SetActive(false);
        }

        Destroy(gameObject);
    }

     public void HideButtons()
    {
        // Disable the buttons
        foreach (var button in buttons)
        {
            button.SetActive(false);
        }
        
        Destroy(gameObject);
        
    }

}
