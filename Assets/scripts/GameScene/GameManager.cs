using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject lightOff;

    void Update() {
        if(lightOff.activeSelf == false) {
            SceneManager.LoadScene("NovelScene",LoadSceneMode.Single);
        }
    }
}
