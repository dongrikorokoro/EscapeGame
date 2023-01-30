using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GameScene4 {
    public class LightController : MonoBehaviour
    {
        private Image light;
        public Sprite lightOff;
        private bool isLight;
        public GameObject lightGround;
        public LoadText text;

        void Awake() {
            light = GetComponent<Image>();
            isLight = false;
            lightGround.SetActive(true);
        }

        public void OnClickObj() {
            if(light.sprite == lightOff) {
                text.UpdateText("電気がついてない...");
            } else {
                text.UpdateText("電球がついてない...");
            }
            GameManager.Instance.clearGimmike(2);
        }
    }
}
