using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Text;

public class CrayonUI : MonoBehaviour
{
    public GameObject Crayon_UI;
    private SpriteRenderer P_render;
    private CharacterColorState ccs;

    private bool is_active = false;

    public StringBuilder Line_tag;

    void Start()
    {
        Crayon_UI.SetActive(false);
        P_render = GameObject.Find("Player").GetComponent<SpriteRenderer>();
        ccs = GameObject.Find("Player").GetComponent<CharacterColorState>();
        Line_tag = new StringBuilder(System.Enum.GetName(typeof(CharacterColorState.ColorState), 0)); // 문제 발생 시 문자열을 딕셔너리로 캐싱하여 사용하기
        Line_tag.Append("Line");
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

    public void OnClickEraser()
    {
        ccs.currentColor = CharacterColorState.ColorState.Origin;
        Line_tag = new StringBuilder(System.Enum.GetName(typeof(CharacterColorState.ColorState), 0));
        Line_tag.Append("Line");
        is_active = false;
        Crayon_UI.SetActive(is_active);
    }

    public void OnClickRed()
    {
        ccs.currentColor = CharacterColorState.ColorState.Red;
        Line_tag = new StringBuilder(System.Enum.GetName(typeof(CharacterColorState.ColorState), 1));
        Line_tag.Append("Line");
        is_active = false;
        Crayon_UI.SetActive(is_active);
    }

    public void OnClickOrenge()
    {
        ccs.currentColor = CharacterColorState.ColorState.Orange;
        Line_tag = new StringBuilder(System.Enum.GetName(typeof(CharacterColorState.ColorState), 2));
        Line_tag.Append("Line");
        is_active = false;
        Crayon_UI.SetActive(is_active);
    }

    public void OnClickYellow()
    {
        ccs.currentColor = CharacterColorState.ColorState.Yellow;
        Line_tag = new StringBuilder(System.Enum.GetName(typeof(CharacterColorState.ColorState), 3));
        Line_tag.Append("Line");
        is_active = false;
        Crayon_UI.SetActive(is_active);
    }

    public void OnClickGreen()
    {
        ccs.currentColor = CharacterColorState.ColorState.Green;
        Line_tag = new StringBuilder(System.Enum.GetName(typeof(CharacterColorState.ColorState), 4));
        Line_tag.Append("Line");
        is_active = false;
        Crayon_UI.SetActive(is_active);
    }

    public void OnClickBlue()
    {
        ccs.currentColor = CharacterColorState.ColorState.Blue;
        Line_tag = new StringBuilder(System.Enum.GetName(typeof(CharacterColorState.ColorState), 5));
        Line_tag.Append("Line");
        is_active = false;
        Crayon_UI.SetActive(is_active);
    }

    public void OnClickPurple()
    {
        ccs.currentColor = CharacterColorState.ColorState.Purple;
        Line_tag = new StringBuilder(System.Enum.GetName(typeof(CharacterColorState.ColorState), 6));
        Line_tag.Append("Line");
        is_active = false;
        Crayon_UI.SetActive(is_active);
    }
}
