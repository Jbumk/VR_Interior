using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransRig : MonoBehaviour
{
    public Transform TransR;    //CameraRig 의 위치
    public Transform TransP;    //Player의 위치
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TransR.transform.position = TransP.transform.position;  //CameraRig의 위치를 Plyaer의 위치로 최신화 해줌(Player기준으로 텔레포트 하기 때문)
    }
}
