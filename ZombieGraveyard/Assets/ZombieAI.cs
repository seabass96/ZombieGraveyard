using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieAI : MonoBehaviour
{
    public enum state { RISE, CHASE, ATTACK, DIE};
    private state currentState;

    public enum zombieType {RUNNER, WALKER }

    private void ZombieState()
    {
        switch (currentState)
        {
            case state.RISE:
                RiseState();
                break;
            case state.CHASE:
                ChaseState();
                break;
            case state.ATTACK:
                AttackState();
                break;
            case state.DIE:
                DieState();
                break;
        }
    }

    private void RiseState()
    {

    }

    private void ChaseState()
    {

    }

    private void AttackState()
    {

    }

    private void DieState()
    {

    }
}
