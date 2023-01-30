using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GameScene6 {
    public class PasswordPanel : MonoBehaviour
    {

        void Awake() {
            gameObject.SetActive(false);
        }

        public void click() {
            hidePanel();
        }

        public void active() {
            gameObject.SetActive(true);
        }

        public void hidePanel() {
            gameObject.SetActive(false);
        }
    }
}
