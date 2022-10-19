using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject player;

    private void Update()
    { //카메라의 위치 = 플레이어의 위치
        transform.position = player.transform.position;
        transform.position -= new Vector3(0, 0, 1);
    }
}
