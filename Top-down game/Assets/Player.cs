using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject shooter;
    public GameObject shield;

    public PlayerMovement playerMovement;
    public PlayerAttack playerAttack;

    public enum State
    {
        shooting,
        shielding
    }

    public State state;

    public void ChangeState(State newState)
    {
        state = newState;
        if (newState == State.shooting)
        {
            shooter.SetActive(true);
            shield.SetActive(false);
        }
        else if (newState == State.shielding)
        {
            shooter.SetActive(false);
            shield.SetActive(true);
        }
    }
}
