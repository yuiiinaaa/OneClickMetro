using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PhoneScreen : MonoBehaviour
{
    private bool isClicked = false;
    private Vector3 originalPosition;
    private Quaternion originalRotation;
    private Vector3 originalScale;

    //public GameObject buttonPrefab;
   // private GameObject[] buttons = new GameObject[9];
    private int currentButtonIndex = 0;

    public GameObject phonePuzzle;

    void Start()
    {
        // Save the original position, rotation, and scale of the object
        originalPosition = transform.position;
        originalRotation = transform.rotation;
        originalScale = transform.localScale;

        // Create buttons and hide them initially
    
    }

    void Update()
    {
        // Check for left mouse click
        if (Input.GetMouseButtonDown(0))
        {
            HandleMouseClick();
        }

        // Check for right mouse click
        if (Input.GetMouseButtonDown(1))
        {
            HandleRightMouseClick();
        }
    }

    void HandleMouseClick()
    {
        // Raycast to check if the left mouse click hits this object
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
        {
            // Set the flag to indicate the object is clicked
            isClicked = true;
            // Show the buttons
            //ShowButtons();
        }

        // Check if the object is clicked and move it to the middle of the screen
        if (isClicked)
        {
            MoveObjectToMiddle();

            // Check for mouse release to stop moving the object
            if (Input.GetMouseButtonUp(0))
            {
                isClicked = false;
            }
        }
    }

    void HandleRightMouseClick()
    {
        //phonePuzzle.HideButtons();
        //DestroyImmediate(phonePuzzle, true);
        // Return the object to its original position on right mouse click
        transform.position = originalPosition;

        // Reset the scale to its original size
        transform.localScale = originalScale;

        // Reset the rotation to its original rotation
        transform.rotation = originalRotation;

  

        // Reset the button sequence
        currentButtonIndex = 0;

        SceneManager.LoadScene("Scene02");
    }

    public void MoveObjectToMiddle()
    {
        //create puzzle game object
        Vector3 cameraPosition = Camera.main.transform.position;
        Instantiate(phonePuzzle);

        // Calculate the middle of the screen in world coordinates
        Vector3 middleOfScreen = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2f, Screen.height / 2f, 0f));

        // Set the object's position to the middle of the screen
        transform.position = new Vector3(middleOfScreen.x, middleOfScreen.y, -10);

        // Scale the object to size two
        //transform.localScale = new Vector3(2f, 2f, 1f);

        // Reset the rotation
        //transform.rotation = Quaternion.identity;
    }

   

  

    // public void ButtonClicked(int buttonValue)
    // {
    //     // Check if the buttons are clicked in the specific order "4013"
    //     if (buttonValue == int.Parse("4013"[currentButtonIndex].ToString()))
    //     {
    //         // Correct button clicked, move to the next in the sequence
    //         currentButtonIndex++;

    //         // Check if the entire sequence is completed
    //         if (currentButtonIndex == 4)
    //         {
    //             Debug.Log("Button sequence completed!");
    //             // Additional actions for completing the sequence can be added here
    //         }
    //     }
    //     else
    //     {
    //         // Incorrect button clicked, reset the sequence
    //         currentButtonIndex = 0;
    //         Debug.Log("Incorrect button clicked. Resetting sequence.");
    //     }
    // }
}