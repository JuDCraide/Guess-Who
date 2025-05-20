using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UI.TableUI;
using TMPro;

public class Menus : MonoBehaviour {

    public void GoToPlay() {
        SceneManager.LoadScene("SampleScene");
    }

    public void GoToMenu() {
        SceneManager.LoadScene("Menu");
    }

    public void GoToHowToPlay() {
        SceneManager.LoadScene("HowToPlay");
    }
}
