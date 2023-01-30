using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene5 {
    public class Calender : MonoBehaviour
    {
        public Item.Type item;
        public LoadText text;
        public ZoomObject zoomObject;

        public void Clicked() {
            zoomObject.active();
        }
    }
}
