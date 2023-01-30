using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GameScene3 {
    public class LightController : MonoBehaviour
    {
        private Image light;
        public Sprite lightOff;
        public Sprite lightOn;
        private bool isLight;
        public GameObject lightGround;
        public LoadText text;
        public Item.Type clearItem;

        void Awake() {
            light = GetComponent<Image>();
            isLight = false;
            lightGround.SetActive(true);
        }

        public void OnClickObj() {
            bool clearGimmike = ItemBox.instance.TryUseItem(clearItem,1);
            if(clearGimmike) {
                text.UpdateText("高くて届かない...");
                GameManager.Instance.denkyuGimmike = true;
            } else if(light.sprite == lightOff) {
                text.UpdateText("電気がついてない...");
            } else {
                text.UpdateText("電球がついてない...");
            }
        }

        public void changeLight() {
            if(isLight) {
                light.sprite = lightOff;
                lightGround.SetActive(true);
                isLight = false;
            } else {
                light.sprite = lightOn;
                lightGround.SetActive(false);
                isLight = true;
            }
        }
    }
}
