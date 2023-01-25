using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectButtonController : MonoBehaviour
{
  public void OnClick() {
    SceneManager.LoadScene("SelectEpisodeScene",LoadSceneMode.Single);
  }
}
