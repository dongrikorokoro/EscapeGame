using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene2 {
    public class ZoomHeartBox : MonoBehaviour
    {
        public LoadText text;
        public PasswordPanel pasPanel;

        public void click() {
            if(GameManager.Instance.boxGimmike) {
                text.UpdateText("「君のもの」と書かれている。中身は空っぽだ");
            } else {
                text.UpdateText("「君のもの」と書かれている");
                pasPanel.active();
            }
        }
    }
}

