using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GameScene1 {
    public class LightController : MonoBehaviour
    {
        private Image light;
        public Sprite lightOff;
        public Sprite lightOn;
        public Item.Type clearItem;
        public bool clear = false;
        private bool isLight = false;
        public GameObject lightGround;
        public LoadText text;

        void Awake() {
            light = GetComponent<Image>();
        }

        void Start() {
            clear = false;
        }

        public void OnClickObj() {
            bool clearGimmike = ItemBox.instance.TryUseItem(clearItem);
            if(clearGimmike) {
                light.sprite = lightOff;
                clear = true;
                text.UpdateText("電球をつけた");
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
