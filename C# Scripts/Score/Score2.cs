using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score2 : MonoBehaviour
{

    public static float scoreValue2 = 0;
    Text score2;
    // Start is called before the first frame update
    void Start()
    {
        score2 = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        score2.text = "P2 Score: " + scoreValue2;
    }
}
