using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameScene4 {
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }
        public TimerScript timer;
        public LoadText text;
        public bool[] gimmike;
        public bool allTouchGimmike;
        public bool clear;


        void Awake() {
            Instance = this;
            allTouchGimmike = false;
            clear = false;
            for(int i = 0; i < gimmike.Length; i++) {
                gimmike[i] = false;
            }
        }

        // Update is called once per frame
        void Update()
        {
            if(isClear()) {
                allTouchGimmike = true;
            }
            if(timer.totalTime <= 0f) {
                SceneManager.LoadScene("NovelScene(GameOver)",LoadSceneMode.Single);
            } else if(clear) {
                SceneManager.LoadScene("NovelScene1-5",LoadSceneMode.Single);
            }
        }

        public bool isClear() {
            for(int i = 0; i < gimmike.Length; i++) {
                if(gimmike[i] == false){ 
                    return false;
                }
            }
            return true;
        }

        public void clearGimmike(int i) {
            gimmike[i] = true;
        }
    }
}
