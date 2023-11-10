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
            Debug.Log("�÷��̾ ���ڸ����� ������Դϴ�.");
        }
        else if (playerState == PlayerState.Walk)
        {
            Debug.Log("�÷��̾ �ɾ�ϴ�.");
        }
        else if (playerState == PlayerState.Run)
        {
            Debug.Log("�÷��̾ �پ�ϴ�.");
        }
        else if (playerState == PlayerState.Attack)
        {
            Debug.Log("�÷��̾ ��ǥ���� �����մϴ�.");
        }
    }
    void ChangeState(PlayerState newState)
    {
        playerState = newState;
    }
}
