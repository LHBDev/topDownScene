using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public Transform player;
    public float smooth = 10f;
    public float cameraHeight = 30;
    public float behindPlayer = 20;

    // Update is called once per frame
	void Update () {
        Vector3 newPos = new Vector3(player.position.x, player.position.y + cameraHeight, player.position.z - behindPlayer);
        transform.position = newPos;
	}
}
