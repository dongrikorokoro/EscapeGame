using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene6 {
    public class Deguchi : MonoBehaviour
    {
        public ZoomObject zoomobject;

        public void click() {
            if(GameManager.Instance.doorGimmike) {
                GameManager.Instance.clear = true;
            } else {
                zoomobject.active();
                GameManager.Instance.clearGimmike(5);
            }
        }
    }
}