using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject player;

    private void Update()
    { //ī�޶��� ��ġ = �÷��̾��� ��ġ
        transform.position = player.transform.position;
        transform.position -= new Vector3(0, 0, 1);
    }
}
