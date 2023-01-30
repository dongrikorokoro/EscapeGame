using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene6 {
    public class Hondana : MonoBehaviour
    {
        public LoadText text;

        public void click() {
            text.UpdateText("昆虫大図鑑全100種という本があった");
            GameManager.Instance.clearGimmike(3);
        }
    }
}
