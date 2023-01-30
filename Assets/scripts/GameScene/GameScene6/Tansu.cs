using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene6 {
    public class Tansu : MonoBehaviour
    {
        public LoadText text;

        public void Clicked() {
            text.UpdateText("タンスがある、中には何もなかった");
            GameManager.Instance.clearGimmike(2);
        }
    }
}
