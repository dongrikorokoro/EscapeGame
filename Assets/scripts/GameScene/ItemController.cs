using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public GameObject[] item;
    public GameObject[] outframe;
    private int input;

    ItemController(int input) {
        this.input = input;
    }

    private bool isEmpty() {
        if(item == null) {
            return true;
        } 
        return false;
    }

    public void clicked() {
        for(int i = 0; i < item.Length; i++) {
            outframe[i].SetActive(false);
        }
        outframe[input].SetActive(true);
    }

    public void setItem() {
        foreach(Slot slot in slots) {
            if(slot.isEmpty()) {
                slot.SetItem(item);
                break;
            }
        }
    }
}
