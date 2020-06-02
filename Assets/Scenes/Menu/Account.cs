using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Account : MonoBehaviour
{
    public Text text_account;
    public InputField inputfield;

    private void Start()
    {
        text_account.text = My_text.myText;
    }
    public void LoadText()
    {
        My_text.myText = inputfield.text;
    }
}
