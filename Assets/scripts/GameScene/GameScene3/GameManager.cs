using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameScene3 {
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }
        public TimerScript timer;
        public bool chairGimmike;
        public bool denkyuGimmike;
        public bool memoGimmike;
        public bool clear;

        void Awake() {
            Instance = this;
            chairGimmike = false;
            denkyuGimmike = false;
            memoGimmike = false;
            clear = false;
        }

        // Update is called once per frame
        void Update()
        {
            if(timer.totalTime <= 0f) {
                SceneManager.LoadScene("NovelScene(GameOver)",LoadSceneMode.Single);
            } else if(clear) {
                SceneManager.LoadScene("NovelScene1-4",LoadSceneMode.Single);
            }
        }
    }
}
