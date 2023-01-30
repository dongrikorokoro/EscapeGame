using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Man : MonoBehaviour
{
    public LoadText text;

    public void click() {
        text.UpdateText("大丈夫ですか？");
    }
}
