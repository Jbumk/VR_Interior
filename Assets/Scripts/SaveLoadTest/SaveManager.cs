using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SaveManager : MonoBehaviour
{
    public GameObject Player;
    int dect_Floor = 0;
    public GameObject floor_1;
    public GameObject floor_2;
    public GameObject floor_3;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //도면 선택시 도면 코드를 저장하는 부분
    public void Floor1()
    {
        dect_Floor = 1;
    }
    public void Floor2()
    {
        dect_Floor = 2;
    }

    public void Save()
    {
        //가구 코드 찾아 저장
        while (true)
        {


            break;//전부 저장시 종료
        }

        //플레이어 위치 X,Y,Z
        PlayerPrefs.SetFloat("PlayerX", Player.transform.position.x);
        PlayerPrefs.SetFloat("PlayerY", Player.transform.position.y);
        PlayerPrefs.SetFloat("PlayerZ", Player.transform.position.z);
        //플레이어 위치한 도면 코드
        PlayerPrefs.SetInt("PlaceCode", dect_Floor);
        //생성된 가구 i 의 코드

        //생성된 가구 i 의 X,Y,Z

        //생성된 가구 I 의 방향


        PlayerPrefs.Save();
    }

    public void Load()
    {
        if (!PlayerPrefs.HasKey("PlayerX"))
            return; 
        //위 키값 받아서 적용
        float Px = PlayerPrefs.GetFloat("PlayerX");
        float Py = PlayerPrefs.GetFloat("PlayerY");
        float Pz = PlayerPrefs.GetFloat("PlayerZ");
        Player.transform.position = new Vector3(Px, Py, Pz);

        int PCode = PlayerPrefs.GetInt("PlaceCode");
        if (PCode == 1)
        {
            floor_1.SetActive(true);
        }
        else if (PCode == 2)
        {
            floor_1.SetActive(true);
        }


    }
}
