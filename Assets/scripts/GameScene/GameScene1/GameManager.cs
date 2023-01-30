using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameScene1 {
    public class GameManager : MonoBehaviour
    {
        public GameObject lightOff;
        public TimerScript timer;

        void Update() {
            if(timer.totalTime <= 0f) {
                SceneManager.LoadScene("NovelScene(GameOver)",LoadSceneMode.Single);
            }
            if(lightOff.activeSelf == false) {
                SceneManager.LoadScene("NovelScene1-2",LoadSceneMode.Single);
            }
        }
    }
}
