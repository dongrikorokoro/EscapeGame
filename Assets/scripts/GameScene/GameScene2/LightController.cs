using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GameScene2 {
    public class LightController : MonoBehaviour
    {
        private Image light;
        public Sprite lightOff;
        public Sprite lightOn;
        private bool isLight;
        public GameObject lightGround;
        public LoadText text;

        void Awake() {
            light = GetComponent<Image>();
            isLight = true;
            lightGround.SetActive(false);
        }

        void Start() {
        }

        public void OnClickObj() {
            if(light.sprite == lightOff) {
                text.UpdateText("電気がついてない...");
            } else {
                text.UpdateText("電気がついている");
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
