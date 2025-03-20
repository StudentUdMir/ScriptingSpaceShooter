using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Player player = collision.GetComponent<Player>();
            //PlayerShoot player = collision.GetComponent<PlayerShoot>();
            player.points++;
            Destroy(this.gameObject);
        }
    }

}
