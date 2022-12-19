using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnding : MonoBehaviour
{
    public GameObject levelEndText;

    // Start is called before the first frame update
    void Start()
    {
        levelEndText.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            levelEndText.SetActive(true);
            Invoke("levelEnd()", 3);

        }
    }

    private void levelEnd()
    {
        SceneManager.LoadScene(0);
    }
}
