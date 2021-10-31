using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{    
    private string name = "";
    private GameObject player;

    #region 씬 열기   
    // 10평대 씬 열기
    public void OpenMainScene()
    {  
        SceneManager.LoadScene("MainMenu");    
    }

    public void Open10DownScene()
    {
        SceneManager.LoadScene("10Down");         
    }

    public void Open20Scene()
    {
        SceneManager.LoadScene("20p");        
    }

    public void OpenBest30to60Scene()
    {
        SceneManager.LoadScene("Best30to60");
    }

    public void quit()
    {
        Application.Quit(); 
    }

    void Start()
    {
        player = GameObject.Find("Player");
    }

    #endregion

    #region 10평대 도면
    // 10평대 1번 오브젝트
    public void Open10Down1()
    {
        name = "도면1";
    }

    // 10평대 2번 오브젝트
    public void Open10Down2()
    {
        name = "도면2";
    }

    // 10평대 3번 오브젝트
    public void Open10Down3()
    {
        name = "도면3";

    }
    #endregion
     void Update()
    {


    }

    public void Find()
    {
        GameObject objects = GameObject.Find(name); // 도면 오브젝트 찾기
        objects.gameObject.SetActive(true);// 오브젝트 활성화

        Transform camera = GameObject.FindGameObjectWithTag("MainCamera").transform;    // 카메라 위치
        Transform cameraPosition = objects.transform.GetChild(0);   // 카메라 위치 옮길 위치

        camera.position = cameraPosition.position;  // 카메라의 위치를 각 도면에 위치한 cameraPosition의 위치로 옮김
    }
    
}
