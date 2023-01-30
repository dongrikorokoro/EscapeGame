using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene5 {
    public class ReturnButton : MonoBehaviour
    {
        public ZoomObject ZoomObject;

        public void click() {
            ZoomObject.hidePanel();
        }
    }
}
