using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectEpisodeButton : MonoBehaviour
{
  public void OnClick(string n) {
    string sceneName = "GameScene" + n;
    SceneManager.LoadScene(sceneName,LoadSceneMode.Single);
  }
}
