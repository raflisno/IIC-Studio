using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    [SerializeField] Transform player;
    Player playerScript;
    [SerializeField] GameObject playerObj;


    // Start is called before the first frame update
    void Start()
    {
        playerScript = playerObj.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.x > transform.position.x)
        {
            transform.localScale = new Vector3(-0.4f, 0.4f, 0.4f);
        }
        else if (player.position.x < transform.position.x)
        {
            transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
        }
    }

    private void OnTriggerEnter2D(Collider2D enemy)
    {
        if (enemy.tag == "Player")
        {
            playerScript.EnemyColl();
            playerScript.dmgPlayer();
            Destroy(this.gameObject);
       }
        else
        {

        }
    }


}
