using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StorySelectButtonController : MonoBehaviour
{
    public void OnClick() {
        SceneManager.LoadScene("GameScene",LoadSceneMode.Single);
    }
}
