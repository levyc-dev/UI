using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameDemo : MonoBehaviour
{
    public InputField userName;
    public Text output;

    public void MyUserButton()
    {
        output.text = userName.text;
    }
}
