using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selector_script : MonoBehaviour
{
    public GameObject Character_1;
    public GameObject Character_2;
    public GameObject Character_3;
    public GameObject Character_4;
    public GameObject Character_5;
    public GameObject Character_6; 
    private Vector3 CharacterPosition;
    private Vector3 OffScreen;
    private int CharacterInt = 1;
    private SpriteRenderer Character_1Render, Character_2Render, Character_3Render, Character_4Render, Character_5Render, Character_6Render;
    private readonly string selectedCharacter = "SelectedCharacter";
    private readonly string selectedCharacter1 = "SelectedCharacter1";
    private readonly string selectedCharacter3 = "SelectedCharacter3";
    private readonly string selectedCharacter4 = "SelectedCharacter4";

    private void Awake()
    {
        CharacterPosition = Character_1.transform.position;
        OffScreen = Character_2.transform.position;
        Character_1Render = Character_1.GetComponent<SpriteRenderer>();
        Character_2Render = Character_1.GetComponent<SpriteRenderer>();
        Character_3Render = Character_1.GetComponent<SpriteRenderer>();
        Character_4Render = Character_1.GetComponent<SpriteRenderer>();
        Character_5Render = Character_1.GetComponent<SpriteRenderer>();
        Character_6Render = Character_1.GetComponent<SpriteRenderer>();

    }

    public void NextCharacter()
    {
        switch(CharacterInt)
        {
            case 1:
                PlayerPrefs.SetInt(selectedCharacter, 1);

                Character_1Render.enabled = false;
                Character_1.transform.position = OffScreen;
                Character_2.transform.position = CharacterPosition;
                Character_2Render.enabled = true;
                CharacterInt++;
                break;

            case 2:
                PlayerPrefs.SetInt(selectedCharacter, 2);
                Character_2Render.enabled = false;
                Character_2.transform.position = OffScreen;
                Character_3.transform.position = CharacterPosition;
                Character_3Render.enabled = true;
                CharacterInt++;
                break;
            case 3:
                PlayerPrefs.SetInt(selectedCharacter, 3);
                Character_3Render.enabled = false;
                Character_3.transform.position = OffScreen;
                Character_4.transform.position = CharacterPosition;
                Character_4Render.enabled = true;
                CharacterInt++;
                break;
            case 4:
                PlayerPrefs.SetInt(selectedCharacter, 4);
                Character_4Render.enabled = false;
                Character_4.transform.position = OffScreen;
                Character_5.transform.position = CharacterPosition;
                Character_5Render.enabled = true;
                CharacterInt++;
                break;
            case 5:
                PlayerPrefs.SetInt(selectedCharacter, 5);
                Character_5Render.enabled = false;
                Character_5.transform.position = OffScreen;
                Character_6.transform.position = CharacterPosition;
                Character_6Render.enabled = true;
                CharacterInt++;
                break;
            case 6:
                PlayerPrefs.SetInt(selectedCharacter, 6);
                Character_6Render.enabled = false;
                Character_6.transform.position = OffScreen;
                Character_1.transform.position = CharacterPosition;
                Character_1Render.enabled = true;
                CharacterInt++;
                ResetInt();
                break;
            default:
                ResetInt();
                break;

        }
    }

    public void PreviousCharacter()
    {
        switch(CharacterInt)
        {
            case 1:
                PlayerPrefs.SetInt(selectedCharacter, 5);
                Character_1Render.enabled = false;
                Character_1.transform.position = OffScreen;
                Character_6.transform.position = CharacterPosition;
                Character_6Render.enabled = true;
                ResetInt();
                break;
            case 2:
            
                PlayerPrefs.SetInt(selectedCharacter, 6);
                Character_2Render.enabled = false;
                Character_2.transform.position = OffScreen;
                Character_1.transform.position = CharacterPosition;
                Character_1Render.enabled = true;
                CharacterInt--;
                
                break;
            case 3:
                PlayerPrefs.SetInt(selectedCharacter, 1);
                Character_3Render.enabled = false;
                Character_3.transform.position = OffScreen;
                Character_2.transform.position = CharacterPosition;
                Character_2Render.enabled = true;
                CharacterInt--;
                break;
            case 4:
                PlayerPrefs.SetInt(selectedCharacter, 2);
                Character_4Render.enabled = false;
                Character_4.transform.position = OffScreen;
                Character_3.transform.position = CharacterPosition;
                Character_3Render.enabled = true;
                CharacterInt--;
                break;
            case 5:
                PlayerPrefs.SetInt(selectedCharacter, 3);
                Character_5Render.enabled = false;
                Character_5.transform.position = OffScreen;
                Character_4.transform.position = CharacterPosition;
                Character_4Render.enabled = true;
                CharacterInt--;
                break;
            case 6:
                PlayerPrefs.SetInt(selectedCharacter, 4);
                Character_6Render.enabled = false;
                Character_6.transform.position = OffScreen;
                Character_5.transform.position = CharacterPosition;
                Character_5Render.enabled = true;
                CharacterInt--;
                break;
            default:
                ResetInt();
                break;

        }
    }

    public void NextCharacter1()
    {
        switch(CharacterInt)
        {
            case 1:
                PlayerPrefs.SetInt(selectedCharacter1, 1);

                Character_1Render.enabled = false;
                Character_1.transform.position = OffScreen;
                Character_2.transform.position = CharacterPosition;
                Character_2Render.enabled = true;
                CharacterInt++;
                break;

            case 2:
                PlayerPrefs.SetInt(selectedCharacter1, 2);
                Character_2Render.enabled = false;
                Character_2.transform.position = OffScreen;
                Character_3.transform.position = CharacterPosition;
                Character_3Render.enabled = true;
                CharacterInt++;
                break;
            case 3:
                PlayerPrefs.SetInt(selectedCharacter1, 3);
                Character_3Render.enabled = false;
                Character_3.transform.position = OffScreen;
                Character_4.transform.position = CharacterPosition;
                Character_4Render.enabled = true;
                CharacterInt++;
                break;
            case 4:
                PlayerPrefs.SetInt(selectedCharacter1, 4);
                Character_4Render.enabled = false;
                Character_4.transform.position = OffScreen;
                Character_5.transform.position = CharacterPosition;
                Character_5Render.enabled = true;
                CharacterInt++;
                break;
            case 5:
                PlayerPrefs.SetInt(selectedCharacter1, 5);
                Character_5Render.enabled = false;
                Character_5.transform.position = OffScreen;
                Character_6.transform.position = CharacterPosition;
                Character_6Render.enabled = true;
                CharacterInt++;
                break;
            case 6:
                PlayerPrefs.SetInt(selectedCharacter1, 6);
                Character_6Render.enabled = false;
                Character_6.transform.position = OffScreen;
                Character_1.transform.position = CharacterPosition;
                Character_1Render.enabled = true;
                CharacterInt++;
                ResetInt();
                break;
            default:
                ResetInt();
                break;

        }
    }

    public void PreviousCharacter1()
    {
        switch(CharacterInt)
        {
            case 1:
                PlayerPrefs.SetInt(selectedCharacter1, 5);
                Character_1Render.enabled = false;
                Character_1.transform.position = OffScreen;
                Character_6.transform.position = CharacterPosition;
                Character_6Render.enabled = true;
                ResetInt();
                break;
            case 2:
            
                PlayerPrefs.SetInt(selectedCharacter1, 6);
                Character_2Render.enabled = false;
                Character_2.transform.position = OffScreen;
                Character_1.transform.position = CharacterPosition;
                Character_1Render.enabled = true;
                CharacterInt--;
                
                break;
            case 3:
                PlayerPrefs.SetInt(selectedCharacter1, 1);
                Character_3Render.enabled = false;
                Character_3.transform.position = OffScreen;
                Character_2.transform.position = CharacterPosition;
                Character_2Render.enabled = true;
                CharacterInt--;
                break;
            case 4:
                PlayerPrefs.SetInt(selectedCharacter1, 2);
                Character_4Render.enabled = false;
                Character_4.transform.position = OffScreen;
                Character_3.transform.position = CharacterPosition;
                Character_3Render.enabled = true;
                CharacterInt--;
                break;
            case 5:
                PlayerPrefs.SetInt(selectedCharacter1, 3);
                Character_5Render.enabled = false;
                Character_5.transform.position = OffScreen;
                Character_4.transform.position = CharacterPosition;
                Character_4Render.enabled = true;
                CharacterInt--;
                break;
            case 6:
                PlayerPrefs.SetInt(selectedCharacter1, 4);
                Character_6Render.enabled = false;
                Character_6.transform.position = OffScreen;
                Character_5.transform.position = CharacterPosition;
                Character_5Render.enabled = true;
                CharacterInt--;
                break;
            default:
                ResetInt();
                break;

        }
    }

    public void NextCharacter3()
    {
        switch(CharacterInt)
        {
            case 1:
                PlayerPrefs.SetInt(selectedCharacter3, 1);

                Character_1Render.enabled = false;
                Character_1.transform.position = OffScreen;
                Character_2.transform.position = CharacterPosition;
                Character_2Render.enabled = true;
                CharacterInt++;
                break;

            case 2:
                PlayerPrefs.SetInt(selectedCharacter3, 2);
                Character_2Render.enabled = false;
                Character_2.transform.position = OffScreen;
                Character_3.transform.position = CharacterPosition;
                Character_3Render.enabled = true;
                CharacterInt++;
                break;
            case 3:
                PlayerPrefs.SetInt(selectedCharacter3, 3);
                Character_3Render.enabled = false;
                Character_3.transform.position = OffScreen;
                Character_4.transform.position = CharacterPosition;
                Character_4Render.enabled = true;
                CharacterInt++;
                break;
            case 4:
                PlayerPrefs.SetInt(selectedCharacter3, 4);
                Character_4Render.enabled = false;
                Character_4.transform.position = OffScreen;
                Character_5.transform.position = CharacterPosition;
                Character_5Render.enabled = true;
                CharacterInt++;
                break;
            case 5:
                PlayerPrefs.SetInt(selectedCharacter3, 5);
                Character_5Render.enabled = false;
                Character_5.transform.position = OffScreen;
                Character_6.transform.position = CharacterPosition;
                Character_6Render.enabled = true;
                CharacterInt++;
                break;
            case 6:
                PlayerPrefs.SetInt(selectedCharacter3, 6);
                Character_6Render.enabled = false;
                Character_6.transform.position = OffScreen;
                Character_1.transform.position = CharacterPosition;
                Character_1Render.enabled = true;
                CharacterInt++;
                ResetInt();
                break;
            default:
                ResetInt();
                break;

        }
    }

    public void PreviousCharacter3()
    {
        switch(CharacterInt)
        {
            case 1:
                PlayerPrefs.SetInt(selectedCharacter3, 5);
                Character_1Render.enabled = false;
                Character_1.transform.position = OffScreen;
                Character_6.transform.position = CharacterPosition;
                Character_6Render.enabled = true;
                ResetInt();
                break;
            case 2:
            
                PlayerPrefs.SetInt(selectedCharacter3, 6);
                Character_2Render.enabled = false;
                Character_2.transform.position = OffScreen;
                Character_1.transform.position = CharacterPosition;
                Character_1Render.enabled = true;
                CharacterInt--;
                
                break;
            case 3:
                PlayerPrefs.SetInt(selectedCharacter3, 1);
                Character_3Render.enabled = false;
                Character_3.transform.position = OffScreen;
                Character_2.transform.position = CharacterPosition;
                Character_2Render.enabled = true;
                CharacterInt--;
                break;
            case 4:
                PlayerPrefs.SetInt(selectedCharacter3, 2);
                Character_4Render.enabled = false;
                Character_4.transform.position = OffScreen;
                Character_3.transform.position = CharacterPosition;
                Character_3Render.enabled = true;
                CharacterInt--;
                break;
            case 5:
                PlayerPrefs.SetInt(selectedCharacter3, 3);
                Character_5Render.enabled = false;
                Character_5.transform.position = OffScreen;
                Character_4.transform.position = CharacterPosition;
                Character_4Render.enabled = true;
                CharacterInt--;
                break;
            case 6:
                PlayerPrefs.SetInt(selectedCharacter3, 4);
                Character_6Render.enabled = false;
                Character_6.transform.position = OffScreen;
                Character_5.transform.position = CharacterPosition;
                Character_5Render.enabled = true;
                CharacterInt--;
                break;
            default:
                ResetInt();
                break;

        }
    }

    public void NextCharacter4()
    {
        switch(CharacterInt)
        {
            case 1:
                PlayerPrefs.SetInt(selectedCharacter4, 1);

                Character_1Render.enabled = false;
                Character_1.transform.position = OffScreen;
                Character_2.transform.position = CharacterPosition;
                Character_2Render.enabled = true;
                CharacterInt++;
                break;

            case 2:
                PlayerPrefs.SetInt(selectedCharacter4, 2);
                Character_2Render.enabled = false;
                Character_2.transform.position = OffScreen;
                Character_3.transform.position = CharacterPosition;
                Character_3Render.enabled = true;
                CharacterInt++;
                break;
            case 3:
                PlayerPrefs.SetInt(selectedCharacter4, 3);
                Character_3Render.enabled = false;
                Character_3.transform.position = OffScreen;
                Character_4.transform.position = CharacterPosition;
                Character_4Render.enabled = true;
                CharacterInt++;
                break;
            case 4:
                PlayerPrefs.SetInt(selectedCharacter4, 4);
                Character_4Render.enabled = false;
                Character_4.transform.position = OffScreen;
                Character_5.transform.position = CharacterPosition;
                Character_5Render.enabled = true;
                CharacterInt++;
                break;
            case 5:
                PlayerPrefs.SetInt(selectedCharacter4, 5);
                Character_5Render.enabled = false;
                Character_5.transform.position = OffScreen;
                Character_6.transform.position = CharacterPosition;
                Character_6Render.enabled = true;
                CharacterInt++;
                break;
            case 6:
                PlayerPrefs.SetInt(selectedCharacter4, 6);
                Character_6Render.enabled = false;
                Character_6.transform.position = OffScreen;
                Character_1.transform.position = CharacterPosition;
                Character_1Render.enabled = true;
                CharacterInt++;
                ResetInt();
                break;
            default:
                ResetInt();
                break;

        }
    }

    public void PreviousCharacter4()
    {
        switch(CharacterInt)
        {
            case 1:
                PlayerPrefs.SetInt(selectedCharacter4, 5);
                Character_1Render.enabled = false;
                Character_1.transform.position = OffScreen;
                Character_6.transform.position = CharacterPosition;
                Character_6Render.enabled = true;
                ResetInt();
                break;
            case 2:
            
                PlayerPrefs.SetInt(selectedCharacter4, 6);
                Character_2Render.enabled = false;
                Character_2.transform.position = OffScreen;
                Character_1.transform.position = CharacterPosition;
                Character_1Render.enabled = true;
                CharacterInt--;
                
                break;
            case 3:
                PlayerPrefs.SetInt(selectedCharacter4, 1);
                Character_3Render.enabled = false;
                Character_3.transform.position = OffScreen;
                Character_2.transform.position = CharacterPosition;
                Character_2Render.enabled = true;
                CharacterInt--;
                break;
            case 4:
                PlayerPrefs.SetInt(selectedCharacter4, 2);
                Character_4Render.enabled = false;
                Character_4.transform.position = OffScreen;
                Character_3.transform.position = CharacterPosition;
                Character_3Render.enabled = true;
                CharacterInt--;
                break;
            case 5:
                PlayerPrefs.SetInt(selectedCharacter4, 3);
                Character_5Render.enabled = false;
                Character_5.transform.position = OffScreen;
                Character_4.transform.position = CharacterPosition;
                Character_4Render.enabled = true;
                CharacterInt--;
                break;
            case 6:
                PlayerPrefs.SetInt(selectedCharacter4, 4);
                Character_6Render.enabled = false;
                Character_6.transform.position = OffScreen;
                Character_5.transform.position = CharacterPosition;
                Character_5Render.enabled = true;
                CharacterInt--;
                break;
            default:
                ResetInt();
                break;

        }
    }

    private void ResetInt()
    {
        if(CharacterInt >=6)
        {
            CharacterInt = 1;
        }
        else 
        {
            CharacterInt = 6;
        }


    }

    public void ChangeScene0()
    {
        SceneManager.LoadScene(0);
    }

    public void ChangeScene1()
    {
        SceneManager.LoadScene(1);
    }

    public void ChangeScene2()
    {
        SceneManager.LoadScene(2);
    }

    public void ChangeScene3()
    {
        SceneManager.LoadScene(3);
    }

    public void ChangeScene4()
    {
        SceneManager.LoadScene(4);
    }

    public void ChangeScene5()
    {
        SceneManager.LoadScene(5);
    }

    
}
