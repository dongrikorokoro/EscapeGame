using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonController : MonoBehaviour
{
    public GameObject menuPanel;

    public void OnClick() {
        if(menuPanel.activeSelf == false) {
            menuPanel.SetActive(true);
        } else {
            menuPanel.SetActive(false);
        }  
    }
}
