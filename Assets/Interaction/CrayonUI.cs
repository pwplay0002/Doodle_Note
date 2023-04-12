using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CrayonUI : MonoBehaviour
{
    public GameObject Crayon_UI;
    private SpriteRenderer P_render;
    private CharacterColorState ccs;

    private bool is_active = false;

    void Start()
    {
        Crayon_UI.SetActive(false);
        P_render = GameObject.Find("Player").GetComponent<SpriteRenderer>();
        ccs = GameObject.Find("Player").GetComponent<CharacterColorState>();
    }

    public void OnClick()
    {
        if (is_active == false)
        {
            is_active = true;
        }
        else
        {
            is_active = false;
        }

        Crayon_UI.SetActive(is_active);
    }

    public void OnClickRed()
    {
        ccs.currentColor = CharacterColorState.ColorState.Red;
        is_active = false;
        Crayon_UI.SetActive(is_active);
    }

    public void OnClickOrenge()
    {
        ccs.currentColor = CharacterColorState.ColorState.Orange;
        is_active = false;
        Crayon_UI.SetActive(is_active);
    }

    public void OnClickYellow()
    {
        ccs.currentColor = CharacterColorState.ColorState.Yellow;
        is_active = false;
        Crayon_UI.SetActive(is_active);
    }

    public void OnClickGreen()
    {
        ccs.currentColor = CharacterColorState.ColorState.Green;
        is_active = false;
        Crayon_UI.SetActive(is_active);
    }

    public void OnClickBlue()
    {
        ccs.currentColor = CharacterColorState.ColorState.Blue;
        is_active = false;
        Crayon_UI.SetActive(is_active);
    }

    public void OnClickPurple()
    {
        ccs.currentColor = CharacterColorState.ColorState.Purple;
        is_active = false;
        Crayon_UI.SetActive(is_active);
    }

    public void OnClickEraser()
    {
        ccs.currentColor = CharacterColorState.ColorState.Origin;
        is_active = false;
        Crayon_UI.SetActive(is_active);
    }
}
