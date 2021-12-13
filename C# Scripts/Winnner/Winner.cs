using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Winner : MonoBehaviour
{
    Text win;
    // Start is called before the first frame update
    void Start()
    {
        win = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (Score2.scoreValue2 > ScoreScript.scoreValue)
        {
            win.text = "P2 WON " ;
        }

        else if (Score2.scoreValue2 < ScoreScript.scoreValue)
        {
            win.text = "P1 WON " ;
        }

        else if (Score2.scoreValue2 == ScoreScript.scoreValue)
        {
            win.text = "Match Draw" ;
        }
    }
}
