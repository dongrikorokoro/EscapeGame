using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectEpisodeButton : MonoBehaviour
{
  public void OnClick(string n) {
    if(n == "0") {
      SceneManager.LoadScene("NovelScene1-1",LoadSceneMode.Single);
    } else {
      string sceneName = "GameScene" + n;
      SceneManager.LoadScene(sceneName,LoadSceneMode.Single);
    }
  }
}
