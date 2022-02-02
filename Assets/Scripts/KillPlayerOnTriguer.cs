using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayerOnTriguer : MonoBehaviour
{
    Collider2D collider2D;
    // Start is called before the first frame update
    void Start()
    {
        collider2D = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }
}
