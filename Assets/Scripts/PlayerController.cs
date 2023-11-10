using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public enum PlayerState { Idle = 0, Walk, Run, Attack }

public class PlayerController : MonoBehaviour
{
    private PlayerState playerState;

    private void Awake()
    {
        ChangeState(PlayerState.Idle);
    }
    
    void Update()
    {
        if(Input.GetKeyDown("1")) ChangeState(PlayerState.Idle);
        else if(Input.GetKeyDown("2")) ChangeState(PlayerState.Walk);
        else if (Input.GetKeyDown("3")) ChangeState(PlayerState.Run);
        else if (Input.GetKeyDown("4")) ChangeState(PlayerState.Attack);

        UpdateState();
    }
    private void UpdateState()
    {
        if(playerState == PlayerState.Idle)
        {
            Debug.Log("플레이어가 제자리에서 대기중입니다.");
        }
        else if (playerState == PlayerState.Walk)
        {
            Debug.Log("플레이어가 걸어갑니다.");
        }
        else if (playerState == PlayerState.Run)
        {
            Debug.Log("플레이어가 뛰어갑니다.");
        }
        else if (playerState == PlayerState.Attack)
        {
            Debug.Log("플레이어가 목표물을 공격합니다.");
        }
    }
    void ChangeState(PlayerState newState)
    {
        playerState = newState;
    }
}
