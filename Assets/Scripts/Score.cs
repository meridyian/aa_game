using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int PinCount = 0;
    public Text text;

    void Start()
    {
        PinCount = 0;
    }

    private void Update()
    {
        text.text = PinCount.ToString();
    }
}
