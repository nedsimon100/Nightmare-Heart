using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraScript : MonoBehaviour
{
    public Transform attachedPlayer;
    public float blendAmount = 0.05f;
    Vector3 curPos;
    Vector3 targetPos;
    float zVal;
    // Use this for initialization
    void Start()
    {
        curPos = transform.position;
        zVal = curPos.z;
    }
    // Update is called once per frame
    void Update()
    {
        targetPos = attachedPlayer.transform.position;
        curPos = targetPos * blendAmount + curPos * (1.0f - blendAmount);
        curPos.z = zVal;
        transform.position = curPos;
    }
}
