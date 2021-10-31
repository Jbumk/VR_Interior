using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToStartPoint : MonoBehaviour
{
    private GameObject Player;
    private GameObject rig;
    private GameObject StPoint_1;
    private GameObject StPoint_2;
    private GameObject StPoint_3;
    private GameObject StPoint_4;
    private GameObject StPoint_5;
    private GameObject StPoint_6;
    private GameObject StPoint_7;
    private GameObject StPoint_8;

    //Plyaer,CameraRig의 위치와 각 도면의 시작지점을 object로 저장
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        rig = GameObject.Find("[CameraRig] (1)");
        StPoint_1 = GameObject.Find("StartPoint_1");
        StPoint_2 = GameObject.Find("StartPoint_2");
        StPoint_3 = GameObject.Find("StartPoint_3");
        StPoint_4 = GameObject.Find("StartPoint_4");
        StPoint_5 = GameObject.Find("StartPoint_5");
        StPoint_6 = GameObject.Find("StartPoint_6");
        StPoint_7 = GameObject.Find("StartPoint_7");
        StPoint_8 = GameObject.Find("StartPoint_8");
    }

    // 이하 함수들 버튼의 해당하는 위치로 이동시켜줌 + 바라보는 방향 조절
    public void toHome()
    {
        Player.transform.position = new Vector3(0, 0, 0);
        
    }
    public void toPoint1()
    {
        Player.transform.position = StPoint_1.transform.position;
    
    }
    public void toPoint2()
    {
        Player.transform.position = StPoint_2.transform.position;
        Player.transform.rotation = Quaternion.Euler(0, 180, 0);
        rig.transform.rotation = Quaternion.Euler(0, 180, 0);
    }
    public void toPoint3()
    {
        Player.transform.position = StPoint_3.transform.position;
   
    }
    public void toPoint4()
    {
        Player.transform.position = StPoint_4.transform.position;
   
    }
    public void toPoint5()
    {
        Player.transform.position = StPoint_5.transform.position;
        Player.transform.rotation = Quaternion.Euler(0, 180, 0);
        rig.transform.rotation = Quaternion.Euler(0, 180, 0);
    }
    public void toPoint6()
    {
        Player.transform.position = StPoint_6.transform.position;
      
    }
    public void toPoint7()
    {
        Player.transform.position = StPoint_7.transform.position;
        Player.transform.rotation = Quaternion.Euler(0, 180, 0);
        rig.transform.rotation = Quaternion.Euler(0, 180, 0);
    }
    public void toPoint8()
    {
        Player.transform.position = StPoint_8.transform.position;
        Player.transform.rotation = Quaternion.Euler(0, 180, 0);
        rig.transform.rotation = Quaternion.Euler(0, 180, 0);
    }
}
