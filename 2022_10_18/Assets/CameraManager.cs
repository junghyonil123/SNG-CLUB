using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject player;

    private void Update()
    { //ī�޶��� ��ġ = �÷��̾��� ��ġ
        
        if (player != null)
        {
            //ī�޶��� ��ġ
            transform.position = new Vector3(player.transform.position.x, 0, 0);
            transform.position -= new Vector3(0, 0, 1);
        }
    }
}
