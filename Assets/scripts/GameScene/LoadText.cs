using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadText : MonoBehaviour
{
    public TextMeshProUGUI text;
    public GameObject panel;

    public void UpdateText(string text) {
        panel.SetActive(true);
        this.text.text = text;
    }
}
