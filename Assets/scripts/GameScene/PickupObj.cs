using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObj : MonoBehaviour
{
    public Item item;

    public void OnClickObj() {
        ItemBox.instance.setItem(item);
        gameObject.SetActive(false);
    }
}
