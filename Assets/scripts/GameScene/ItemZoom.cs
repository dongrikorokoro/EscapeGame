using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemZoom : MonoBehaviour
{
    public LoadText text;

    public void ClickItem() {
        text.UpdateText("電球だ");
    }
}
