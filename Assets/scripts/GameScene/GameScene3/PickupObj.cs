using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene3 {
    public class PickupObj : MonoBehaviour
    {
        public Item item;
        public LoadText text;

        public void OnClickObj() {
            if(GameManager.Instance.chairGimmike) {
                ItemBox.instance.setItem(item);
                gameObject.SetActive(false);
                text.UpdateText("電球を手に入れた");
            } else {
                text.UpdateText("暗くてよく見えない...");
            }
        }
    }
}