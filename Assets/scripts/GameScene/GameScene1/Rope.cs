using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour
{
    public LoadText text;

    public void click() {
        text.UpdateText("男性が縛られていた縄だ");
    }
}
