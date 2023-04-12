using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterColorState : MonoBehaviour
{
    public enum ColorState
    {
        Origin = 0,
        Red = 1,
        Orange = 2,
        Yellow = 3,
        Green = 4,
        Blue = 5,
        Purple = 6
    };

    public ColorState _ColorState { get; set; }

    public ColorState currentColor; // Current color of the character

    void Start()
    {
        currentColor = ColorState.Origin;
    }

    void Update()
    {
        SetColor();
    }

    // Method to set the character's color based on the current color state
    void SetColor()
    {
        switch (currentColor)
        {
            case ColorState.Origin:
                GetComponent<SpriteRenderer>().material.color = new Color(1, 1, 1, 1);
                break;

            case ColorState.Red:
                GetComponent<SpriteRenderer>().material.color = new Color(1, 0, 0, 1);
                break;

            case ColorState.Orange:
                GetComponent<SpriteRenderer>().material.color = new Color(1, 0.5f, 0, 1);
                break;

            case ColorState.Yellow:
                GetComponent<SpriteRenderer>().material.color = new Color(1, 1, 0, 1);
                break;

            case ColorState.Green:
                GetComponent<SpriteRenderer>().material.color = new Color(0, 1, 0, 1);
                break;

            case ColorState.Blue:
                GetComponent<SpriteRenderer>().material.color = new Color(0, 0, 1, 1);
                break;

            case ColorState.Purple:
                GetComponent<SpriteRenderer>().material.color = new Color(1, 0, 1, 1);
                break;
        }
    }
}
