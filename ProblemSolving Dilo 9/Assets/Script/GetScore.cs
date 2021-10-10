using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetScore : MonoBehaviour
{
    PlayerScore score;
    GameObject player;

    private void Start()
    {
        player = GameObject.Find("Circle");
        score = player.GetComponent<PlayerScore>();
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            score.addScore();
            Destroy(gameObject);
        }
    }
}
