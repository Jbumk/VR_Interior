using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
    public GameObject bed_1;
    public GameObject bed_2;


    //침실 ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
    public GameObject living_1;
    public GameObject living_2;
    public GameObject living_3;
    public GameObject living_4;
    public GameObject living_5;

    //거실 ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
    public GameObject kitchen_1;
    public GameObject kitchen_2;


    //주방 ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

    public GameObject chair_1;
    public GameObject chair_2;

    //책상/의자 ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
    public GameObject Happliances_1;
    public GameObject Happliances_2;
   

    //가전 ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

    public GameObject etc_1;
    public GameObject etc_2;
 

    //기타 ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ


    private GameObject chair_inst;
    private Transform chairTransform;
    private GameObject panelTransform;
    private GameObject cameraRigTransform;
    int check = 0; //가구의 추가를 체크함


    public static int CodeCheck = 0; //배열 Furn_Code의 순환 담당 ex) 추가시 ++ 삭제시 --
    public static int[] Furn_Code = new int [100];  //각각 대응하는 가구들의 3자리 코드저장
                    // ex) 카테고리  침실 ~ 기타 = 1 ~ 6
                    //     목록내 추가 순서대로 99까지 증가
                    //     침실가구의 1번 가구 = 101
    
    

    void Start()
    {
        panelTransform = this.gameObject;   //대응하는 가구 생성판의 위치
        cameraRigTransform = GameObject.Find("[CameraRig] (1)");    //CameraRig의 위치

    }

    //생성판에서 클릭한 가구를 생성판과 Camerarig의 사이에 생성
    //침실
    public void ImportBed_1()
    {
        Vector3 ImportC = new Vector3((cameraRigTransform.transform.position.x + panelTransform.transform.position.x) / 2,
            (cameraRigTransform.transform.position.y + 2),
            (cameraRigTransform.transform.position.z + panelTransform.transform.position.z) / 2);

        Instantiate(bed_1, ImportC, bed_1.transform.rotation);

        PriceManager.Price += 359000;   //PriceManager의 Price값 추가
        PriceManager.Name[check] = "이케아 침대   359,000원\n"; //PriceManager의 Name배열 내용 추가
        check++;    //나와있는 가구의 수를 샌다
        PriceManager.i2 = 1;    //PriceManager의 초기화 감지 함수에 1 입력
    }                           //이하 함수들 동일

    public void ImportBed_2()
    {
        Vector3 ImportC = new Vector3((cameraRigTransform.transform.position.x + panelTransform.transform.position.x) / 2,
            (cameraRigTransform.transform.position.y + 2),
            (cameraRigTransform.transform.position.z + panelTransform.transform.position.z) / 2);

        Instantiate(bed_2, ImportC, bed_2.transform.rotation);
        PriceManager.Price += 649000;
        PriceManager.Name[check] = "한샘몰 침대   649,000원\n";
        check++;
        PriceManager.i2 = 1;
    }




    //거실
    public void ImportSofa_1()
    {
        Vector3 ImportC = new Vector3((cameraRigTransform.transform.position.x + panelTransform.transform.position.x) / 2,
            (cameraRigTransform.transform.position.y + 2),
            (cameraRigTransform.transform.position.z + panelTransform.transform.position.z) / 2);

        Instantiate(living_1, ImportC, cameraRigTransform.transform.rotation);

        PriceManager.Price += 1384450;
        PriceManager.Name[check] = "CJMall 소파   1,384,450원\n";
        check++;
        PriceManager.i2 = 1;
    }

    public void ImportTable_1()
    {
        Vector3 ImportC = new Vector3((cameraRigTransform.transform.position.x + panelTransform.transform.position.x) / 2,
            (cameraRigTransform.transform.position.y + 1),
            (cameraRigTransform.transform.position.z + panelTransform.transform.position.z) / 2);

        Instantiate(living_2, ImportC, cameraRigTransform.transform.rotation);


    }

    public void ImportTable_2()
    {
        Vector3 ImportC = new Vector3((cameraRigTransform.transform.position.x + panelTransform.transform.position.x) / 2,
            (cameraRigTransform.transform.position.y + 1),
            (cameraRigTransform.transform.position.z + panelTransform.transform.position.z) / 2);

        Instantiate(living_3, ImportC, cameraRigTransform.transform.rotation);

        PriceManager.Price += 238000;
        PriceManager.Name[check] = "페라모 테이블   238,000원\n";
        check++;
        PriceManager.i2 = 1;
    }

    public void ImportTable_3()
    {
        Vector3 ImportC = new Vector3((cameraRigTransform.transform.position.x + panelTransform.transform.position.x) / 2,
            (cameraRigTransform.transform.position.y + 1),
            (cameraRigTransform.transform.position.z + panelTransform.transform.position.z) / 2);

        Instantiate(living_4, ImportC, cameraRigTransform.transform.rotation);

        PriceManager.Price += 199000;
        PriceManager.Name[check] = "내추럴하우스 테이블   199,000원\n";
        check++;
        PriceManager.i2 = 1;
    }

    public void ImportSofa_2()
    {
        Vector3 ImportC = new Vector3((cameraRigTransform.transform.position.x + panelTransform.transform.position.x) / 2,
            (cameraRigTransform.transform.position.y + 2),
            (cameraRigTransform.transform.position.z + panelTransform.transform.position.z) / 2);

        Instantiate(living_5, ImportC, cameraRigTransform.transform.rotation);

        PriceManager.Price += 650000;
        PriceManager.Name[check] = "소파1975 소파   650,000원\n";
        check++;
        PriceManager.i2 = 1;
    }







    //주방
    public void Importrefr_1()
    {
        Vector3 ImportC = new Vector3((cameraRigTransform.transform.position.x + panelTransform.transform.position.x) / 2,
            (cameraRigTransform.transform.position.y + 2),
            (cameraRigTransform.transform.position.z + panelTransform.transform.position.z) / 2);

        Instantiate(kitchen_1, ImportC, cameraRigTransform.transform.rotation);

        PriceManager.Price += 3341900;
        PriceManager.Name[check] = "지멘스 냉장고   3,341,900원\n";
        check++;
        PriceManager.i2 = 1;
    }

    public void Importrefr_2()
    {
        Vector3 ImportC = new Vector3((cameraRigTransform.transform.position.x + panelTransform.transform.position.x) / 2,
            (cameraRigTransform.transform.position.y + 2),
            (cameraRigTransform.transform.position.z + panelTransform.transform.position.z) / 2);

        Instantiate(kitchen_2, ImportC, cameraRigTransform.transform.rotation);

        PriceManager.Price += 1059000;
        PriceManager.Name[check] = "삼성 냉장고   1,059,000원\n";
        check++;
        PriceManager.i2 = 1;
    }





    //책상/의자
    public void ImportChair_1()
    {
        Vector3 ImportC = new Vector3((cameraRigTransform.transform.position.x + panelTransform.transform.position.x) / 2,
            (cameraRigTransform.transform.position.y + 1),
            (cameraRigTransform.transform.position.z + panelTransform.transform.position.z) / 2);

        Instantiate(chair_1, ImportC, cameraRigTransform.transform.rotation);

        PriceManager.Price += 282000;
        PriceManager.Name[check] = "한샘 목재의자   282,000원\n";
        check++;
        PriceManager.i2 = 1;
    }


    public void ImportChair_2()
    {
        Vector3 ImportC = new Vector3((cameraRigTransform.transform.position.x + panelTransform.transform.position.x) / 2,
            (cameraRigTransform.transform.position.y + 1),
            (cameraRigTransform.transform.position.z + panelTransform.transform.position.z) / 2);

        Instantiate(chair_2, ImportC, cameraRigTransform.transform.rotation);
        PriceManager.Price += 74300;
        PriceManager.Name[check] = "블루밍홈 알미늄의자   74,300원\n";
        check++;
        PriceManager.i2 = 1;
    }

    //가전

    public void ImportTv_1()
    {
        Vector3 ImportC = new Vector3((cameraRigTransform.transform.position.x + panelTransform.transform.position.x) / 2,
            (cameraRigTransform.transform.position.y + 1),
            (cameraRigTransform.transform.position.z + panelTransform.transform.position.z) / 2);

        Instantiate(Happliances_1, ImportC, cameraRigTransform.transform.rotation);

        PriceManager.Price += 0;
        PriceManager.Name[check] = "LG TV  - 원\n";
        check++;
        PriceManager.i2 = 1;
    }

    public void ImportTv_2()
    {
        Vector3 ImportC = new Vector3((cameraRigTransform.transform.position.x + panelTransform.transform.position.x) / 2,
            (cameraRigTransform.transform.position.y + 1),
            (cameraRigTransform.transform.position.z + panelTransform.transform.position.z) / 2);

        Instantiate(Happliances_2, ImportC, cameraRigTransform.transform.rotation);

        PriceManager.Price += 94050;
        PriceManager.Name[check] = "삼성 TV  94,050원\n";
        check++;
        PriceManager.i2 = 1;
    }
    





    //기타
    public void ImportLamp_1()
    {
        Vector3 ImportC = new Vector3((cameraRigTransform.transform.position.x + panelTransform.transform.position.x) / 2,
            (cameraRigTransform.transform.position.y + 1),
            (cameraRigTransform.transform.position.z + panelTransform.transform.position.z) / 2);

        Instantiate(etc_1, ImportC, cameraRigTransform.transform.rotation);

        PriceManager.Price += 225100;
        PriceManager.Name[check] = "럭비스토어 스텐드  225,100원\n";
        check++;
        PriceManager.i2 = 1;
    }


    public void ImportIronMan()
    {
        Vector3 ImportC = new Vector3((cameraRigTransform.transform.position.x + panelTransform.transform.position.x) / 2,
            (cameraRigTransform.transform.position.y + 1),
            (cameraRigTransform.transform.position.z + panelTransform.transform.position.z) / 2);

        Instantiate(etc_2, ImportC, cameraRigTransform.transform.rotation);

        PriceManager.Price += 559000;
        PriceManager.Name[check] = "Figure City 아이언맨  559,000원\n";
        check++;
        PriceManager.i2 = 1;
    }








}
