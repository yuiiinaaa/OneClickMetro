using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScrollText : MonoBehaviour
{

    public float speed = 10.0f;
    public float textPosBegin = -142.0f;
    public float boundaryTextEnd = -2600.0f;

    RectTransform myGorectTransform;
    [SerializeField]
    TextMeshProUGUI mainText;

    [SerializeField]
    public bool isLooping = false;

    // Start is called before the first frame update
    void Start()
    {
        myGorectTransform = gameObject.GetComponent<RectTransform>();
        StartCoroutine(AutoScrollText());
    }

    IEnumerator AutoScrollText()
    {
        while (myGorectTransform.localPosition.x > boundaryTextEnd)
        {
            myGorectTransform.Translate(Vector3.left * speed * Time.deltaTime);
            yield return null;
        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
