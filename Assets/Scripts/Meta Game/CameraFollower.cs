using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] GameObject Player;

    void Update()
    {
        gameObject.transform.position = new Vector3(Player.transform.position.x, gameObject.transform.position.y, Player.transform.position.z);
    }
}
