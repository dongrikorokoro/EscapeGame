using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameScene2 {
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }
        public TimerScript timer;
        public HeartDoor heartdoor;

        public bool dollGimmike;
        public bool boxGimmike;
        public bool doorGimmike;
        public bool clear;

        void Awake() {
            Instance = this;
            dollGimmike = false;
            boxGimmike = false;
            doorGimmike = false;
            clear = false;
        }

        // Update is called once per frame
        void Update()
        {
            if(timer.totalTime <= 0f) {
                SceneManager.LoadScene("NovelScene(GameOver)",LoadSceneMode.Single);
            } else if(clear) {
                SceneManager.LoadScene("NovelScene1-3",LoadSceneMode.Single);
            }
        }
    }
}
