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
		textMeshPro.ForceMeshUpdate();
		Vector2 textSize = textMeshPro.GetRenderedValues(false);

		Vector2 padding = new Vector2(4f, 2f);
		backgroundSpriteRenderer.size = textSize + padding;
    }
}
//https://www.youtube.com/watch?v=K13WnNL1OYM 6:37
//https://www.youtube.com/watch?v=LdoImzaY6M4 6:39
