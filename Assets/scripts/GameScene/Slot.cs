using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public Item item;
    public Image image;
    public GameObject backgroundPanel;

    void Awake() {
        image = GetComponent<Image>();
    }

    void Start()
    {
     backgroundPanel.SetActive(false);   
    }

    public bool IsEmpty() {
        if(item == null) {
            return true;
        } else {
            return false;
        }
    }

    public void setItem(Item item) {
        this.item = item;
        UpdateImage(item);
    }

    void UpdateImage(Item item) {
        if(item == null) {
            image.sprite = null;
        } else {
            image.sprite = item.sprite;
        }
    }

    public bool OnSelected() {
        if(item == null) {
            return false;
        } else {
            backgroundPanel.SetActive(true);
            return true;
        }
    }

    public void HideBgPanel() {
        backgroundPanel.SetActive(false);
    }

    public Item GetItem() {
        return item;
    }
}
