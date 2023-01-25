using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

//using TMPro;

[System.Serializable]
public class ColorEvent : UnityEvent<Color> {}



public class ColorPicker : MonoBehaviour
{
    //public TextMeshProUGUI DebugText;
    RectTransform Rect;
    Texture2D ColorTexture;
    public ColorEvent OnColorPreview;
    public Material material;

    void Start()
    {
        Rect = GetComponent<RectTransform>();
        ColorTexture = GetComponent<Image>().mainTexture as Texture2D;
      
    }



    void Update()
    {
        if (RectTransformUtility.RectangleContainsScreenPoint(Rect, Input.mousePosition))
        {
        Vector2 delta;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(Rect, Input.mousePosition, null, out delta);
        string debug = "mousePosition=" + Input.mousePosition;
        debug += "<br>delta=" + delta;
        float width = Rect.rect.width;
        float height = Rect.rect.height;
        delta += new Vector2(width * .5f, height * .5f);
        debug += "<br>offset delta=" + delta;

        float x = Mathf.Clamp(delta.x / width, 0f, 1);
        float y = Mathf.Clamp(delta.y / height, 0f, 1);
        debug += "<br>x=" + x + "y=" + y;

        int texx = Mathf.RoundToInt(x * ColorTexture.width);
        int texy = Mathf.RoundToInt(y * ColorTexture.height);
        debug += "<br>x=" + texx + "y=" + texy;

        Color color = ColorTexture.GetPixel(texx, texy);

        OnColorPreview?.Invoke(color);

        if (Input.GetMouseButtonDown(0))
        {
            //OnColorSelect?.Invoke(color);
            material.color = color; 
        }
        //DebugText.text = debug;
        }

    }

}
