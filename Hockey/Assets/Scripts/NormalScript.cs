using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalScript : MonoBehaviour {

    public GameManager gameManager;

    void OnCollisionEnter()
    {
        Destroy(gameObject);
        gameManager.score += 10;
    }
}
