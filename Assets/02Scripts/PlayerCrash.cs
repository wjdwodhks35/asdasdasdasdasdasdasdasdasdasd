using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCrash : MonoBehaviour
{
    public string Gameover;

    void Start()
    { 
    
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("Gameover");
        }
    }
}
