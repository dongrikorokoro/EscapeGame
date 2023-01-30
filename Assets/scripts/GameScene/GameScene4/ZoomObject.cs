using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene4 {
    public class ZoomObject : MonoBehaviour
    {
        public GameObject ZoomObjectPanel;
        public GameObject Floor;

        void Awake() {
            ZoomObjectPanel.SetActive(false);
            Floor.SetActive(true);
        }
        
        public void active() {
            Floor.SetActive(false);
            ZoomObjectPanel.SetActive(true);
        }

        public void hidePanel() {
            ZoomObjectPanel.SetActive(false);
            Floor.SetActive(true);
        }
    }
}
