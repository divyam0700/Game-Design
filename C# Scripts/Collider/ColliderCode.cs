using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliderCode : MonoBehaviour
{
    private int hit = 0;
    private float s1 = 600;
    private float s2 = 300;

    Vector3 temp;
    public GameObject char2;


    private void OnTriggerEnter2D(Collider2D other){
        hit += 1;
        temp = transform.localScale;
        //this.gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
       
         
        if (hit == 18)
        {
            SceneManager.LoadScene("EndScene");
        }

        else if (other.gameObject.name != "MainCharacter2" && other.gameObject.name != "MainCharacter4")
        {
            if (char2.name == "MainCharacter2")
            {
                Debug.Log("mc");
                Score2.scoreValue2 += s1;
                s1 = s1/1.2f;
            }

            else
            {
                Debug.Log("mc1");
                Score2.scoreValue2 += s2;
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