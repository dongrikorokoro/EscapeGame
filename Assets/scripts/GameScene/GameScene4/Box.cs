using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene4 {
    public class Box : MonoBehaviour
    {
        public LoadText text;
        public ZoomObject zoomObject;

        public void Clicked() {
            zoomObject.active();
        }
    }
}