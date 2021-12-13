using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collider2 : MonoBehaviour
{
    private int hit = 0;
    private float s1 = 500;
    private float s2 = 400;

    Vector3 temp;
    public GameObject char1;

    private void OnTriggerEnter2D(Collider2D other){
        hit += 1;
        temp = transform.localScale;
        //this.gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
       
         
        if (hit == 18)
        {
            SceneManager.LoadScene("EndScene");
        }

        else if (other.gameObject.name != "MainCharacter" && other.gameObject.name != "MainCharacter3")
        {
            if (char1.name == "MainCharacter")
            {
                Debug.Log("mc");
                ScoreScript.scoreValue += s1;
                s1 = s1/1.2f;
            }

            else
            {
                Debug.Log("mc1");
                ScoreScript.scoreValue += s2;
                s2 = s2/1.2f;
            }

            Debug.Log("Life Reduced"); 
            Debug.Log(other.gameObject.name);
            temp.x = temp.x/1.2f;
            temp.y = temp.y/1.2f;
            transform.localScale = temp;
           
        }
    }
}