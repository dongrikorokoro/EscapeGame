using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene2 {
    public class ZoomCloverBox : MonoBehaviour
    {
        public LoadText text;
        public PasswordPanel pasPanel;

        public void click() {
            text.UpdateText("「僕のもの」と書かれている");
            pasPanel.active();
        }
    }
}
