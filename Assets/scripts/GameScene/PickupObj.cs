using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObj : MonoBehaviour
{
    public Item item;
    public ZoomPanelController zoomPanel;
    public LoadText text;

    public void OnClickObj() {
        ItemBox.instance.setItem(item);
        gameObject.SetActive(false);
        text.UpdateText("電球を手に入れた");
    }
}
