using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMainCharacter : MonoBehaviour
{
    
    public Sprite Character_1, Character_2, Character_3, Character_4, Character_5, Character_6;
    private SpriteRenderer mySprite;
    private readonly string selectedCharacter = "SelectedCharacter";
    
    
    void Awake()
    {
        mySprite = this.GetComponent<SpriteRenderer>();
    }


    void Start()
    {
        int getCharacter;
        getCharacter = PlayerPrefs.GetInt(selectedCharacter);

        switch(getCharacter)
        {
            case 1:
                mySprite.sprite = Character_2;
                break;
            case 2:
                mySprite.sprite = Character_3;
                break;
            case 3:
                mySprite.sprite = Character_4;
                break;
            case 4:
                mySprite.sprite = Character_5;
                break;
            case 5:
                mySprite.sprite = Character_6;
                break;
            case 6:
                mySprite.sprite = Character_1;
                break;
            default:
                mySprite.sprite = Character_1;
                break;
            
        }
    }
}
