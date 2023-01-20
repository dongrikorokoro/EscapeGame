using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextManager : MonoBehaviour
{
    public GameObject panel;
    public void Clicked() {
        panel.SetActive(false);
    }
}
