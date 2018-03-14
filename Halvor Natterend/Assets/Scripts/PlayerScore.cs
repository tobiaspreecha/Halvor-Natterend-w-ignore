using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerScore : MonoBehaviour {

    private float keys = 0.0f;
    private bool isFound;

    public GameObject KeyUI;


    private bool isDead = false;
	// Use this for initialization
	void Start () {
        isFound = false;
	}
	
	// Update is called once per frame
	void Update () {
        KeyUI.gameObject.GetComponent<Text>().text = "" + keys;
        isAlive();
	}
    private void debud()
    {
        if (Input.GetKeyDown(KeyCode.R))
            {
            OnDeath();
            }
    }
    private void OnTriggerEnter2D(Collider2D _trig)
    {
        if (_trig.gameObject.tag.Equals("Key"))
        {
            CoinScore(_trig.gameObject);
        }
    }
    public void CoinScore(GameObject _go)
    {
        Debug.Log("keys picked up");
        keys += 1.0f;
        Destroy(_go);
    }
    private void isAlive()
    {
        if (isFound == true)
        {
            OnDeath();
        }
    }
    private void OnDeath()
    {
        isDead = true;
        if (isDead == true)
        {
            SceneManager.LoadScene(3);
        }
    }
}
