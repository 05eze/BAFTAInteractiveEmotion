using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;


public class Error : MonoBehaviour
{
    [SerializeField] Button _button1;
    [SerializeField] TMP_Text _button1Text;
    [SerializeField] TMP_Text _popupText;
    [SerializeField] TMP_Text _popup2Text;

    public void Init(Transform canvas, string popupMessage, string btn1txt, string btn2txt, System.Action action)
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
//https://www.youtube.com/watch?v=Bm62aXuVX4I 6:41