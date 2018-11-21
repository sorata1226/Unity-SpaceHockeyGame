using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtomWallScript : MonoBehaviour {

    public GameManager gameManager;
    public GameObject ballPrefab;
    Vector3 placePosition = new Vector3(0f, 0.6f, -7f);


    void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);

        if (gameManager.life > 0)
        {
            Instantiate(
                ballPrefab,
                placePosition,
                Quaternion.identity
            );
            gameManager.life--;
        }
        else if (gameManager.life == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
