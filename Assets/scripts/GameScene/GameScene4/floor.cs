using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene4 {
    public class floor : MonoBehaviour
    {
        public LoadText text;

        public void click() {
            if(GameManager.Instance.allTouchGimmike) {
                text.UpdateText("床からバンバンと音がする...");
            }
        }       
    }
}