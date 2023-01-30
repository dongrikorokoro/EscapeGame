using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonController : MonoBehaviour
{
    public GameObject menuPanel;

    void Awake() {
        menuPanel.SetActive(false);
    }

    public void OnClick() {
        if(menuPanel.activeSelf == false) {
            menuPanel.SetActive(true);
        } else {
            menuPanel.SetActive(false);
        }  
    }
}
