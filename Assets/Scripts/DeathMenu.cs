using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour {

    public Text keysText;
    // Use this for initialization
    void Start() {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update() {

    }
    public void ToggleDeathMenu(float keys)
    {
        gameObject.SetActive(true);
        keysText.text = ((int)keys).ToString();
    }

    public void restart ()
    {
        SceneManager.LoadScene(1);
    }

    public void ToMainMenu ()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitClick ()
    {
        Application.Quit();
    }
}