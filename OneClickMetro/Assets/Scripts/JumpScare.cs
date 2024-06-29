using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpScare : MonoBehaviour
{
    public float lifetime = 4;
    public GameObject scaryManPrefab;
    public AudioClip scarySound;

    void Start()
    {
        StartCoroutine(DestroyAfterTime());
    }

    IEnumerator DestroyAfterTime()
    {
        yield return new WaitForSeconds(1); // Wait for 1 second before showing the scare man

        // Get the main camera's position
        Camera mainCamera = Camera.main;
        Vector3 cameraPosition = mainCamera.transform.position;
        cameraPosition.z = 0;  // Set the z component to 0

        // Instantiate the scaryMan at the middle of the camera
        GameObject scaryManInstance = Instantiate(scaryManPrefab, cameraPosition, Quaternion.identity);

        // Get the ScaryManController component and trigger the sprite change
        ScaryManController scaryManController = scaryManInstance.GetComponent<ScaryManController>();
        if (scaryManController != null)
        {
            scaryManController.StartSpriteChange();
        }

        // Play the scary sound
        if (scarySound != null)
        {
            AudioSource.PlayClipAtPoint(scarySound, cameraPosition);
        }

        yield return new WaitForSeconds(2);

        // Set the lifetime for the scaryManInstance
        Destroy(scaryManInstance, lifetime);

        // Destroy the JumpScare object
        Destroy(gameObject);

        SceneManager.LoadScene("Scene11");
    }

    // Update is called once per frame
    void Update()
    {
        // You can add any additional logic here if needed
    }
}
