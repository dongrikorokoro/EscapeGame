using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene2 {
    public class PasswordClick : MonoBehaviour
    {
        public PasswordPanel pasPanel;

        public void click() {
            pasPanel.active();
        }
    }
}
