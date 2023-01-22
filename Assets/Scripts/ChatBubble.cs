using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChatBubble : MonoBehaviour
{
    private SpriteRenderer backgroundSpriteRenderer;
    private TextMeshPro textMeshPro;

    private void Awake()
    {
        backgroundSpriteRenderer = transform.Find("Background").GetComponent<SpriteRenderer>();
        textMeshPro = transform.Find("Text").GetComponent<TextMeshPro>();
    }
    private void Start()
    {
        Setup("Hello World!");
    }
    private void Setup(string text)
    {
        textMeshPro.SetText(text);
    }
}
//https://www.youtube.com/watch?v=K13WnNL1OYM 5:01
//https://www.youtube.com/watch?v=LdoImzaY6M4 6:39
