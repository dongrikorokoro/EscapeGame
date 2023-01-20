using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    public Slot[] slots;
    public Slot selectedSlot = null;

    public static ItemBox instance;
    private void Awake() {
        if(instance == null) {
            instance = this;
        }
    }

    public void OnSelectedSlot(int position) {
        foreach(Slot slot in slots) {
            slot.HideBgPanel();
        }

        if(slots[position].OnSelected()) {
            selectedSlot = slots[position];
        }
    }

    public void setItem(Item item) {
        foreach(Slot slot in slots) {
            if(slot.IsEmpty()) {
                slot.setItem(item);
                break;
            }
        }
    }

    public bool TryUseItem(Item.Type type) {
        if(selectedSlot == null) {
            return false;
        }

        if(selectedSlot.GetItem().type == type) {
            selectedSlot.setItem(null);
            selectedSlot.HideBgPanel();
            selectedSlot = null;
            return true;
        }
        return false;
    }
}
