using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject bullet;

    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (player.state != Player.State.shooting)
            {
                player.ChangeState(Player.State.shooting);
            }
            Instantiate(bullet, transform.position, transform.rotation);
        }
        else if (Input.GetMouseButtonDown(1))
        {
            if (player.state != Player.State.shielding)
            {
                player.ChangeState(Player.State.shielding);
            }
        }
    }
}
