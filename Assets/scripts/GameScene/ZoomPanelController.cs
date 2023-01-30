using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomPanelController : MonoBehaviour
{
    public GameObject zoomPanel;
    public GameObject[] itemPanel;
    public Item[] items;

    void Awake() {
        zoomPanel.SetActive(false);
        for(int i = 0; i < itemPanel.Length; i++) {
            itemPanel[i].SetActive(false);
        }
    }

    public void activePanel(Item item) {
        for(int i = 0; i < itemPanel.Length; i++) {
            itemPanel[i].SetActive(false);
        }
        for(int i = 0; i < itemPanel.Length; i++) {
            if(item.type == items[i].type) {
                itemPanel[i].SetActive(true);
            }
        }
        zoomPanel.SetActive(true);
    }

    public void Click() {
        zoomPanel.SetActive(false);
    }
}
