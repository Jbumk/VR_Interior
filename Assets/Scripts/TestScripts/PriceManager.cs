using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PriceManager : MonoBehaviour
{
    public static int Price=0;
    public static string[] Name = new string[30];  
    public static int i2 = 0; //새로고침 여부
    public static string delName=null;


    public Text PriceText;
    public Text Total;
    private GameObject PricePlane;
    
    //뒤로가기 했을시 메뉴판 초기화
    public void ToHome()
    {
        for( int j=0; j<30; j++)
        {
            Name[j] = "";           
        }       
        Price = 0;
        i2 = 1;
        PriceText.text = "가구 리스트";
        //내부가구 삭제 함수 추가 필요
    }
    // Update is called once per frame
    void Update()
    {
        if (delName != null)//DelPointer에서 가져온 delName이 비어있을때 해당 단어와 대조해 현황판내용 수정후 초기화
        { 
            
               //침실가구
                if (delName.Equals("bed1(Clone)"))
                {
                    for (int j = 0; j < 30; j++)
                    {
                     if (Name[j].Equals("이케아 침대   359,000원\n"))
                        {
                         Name[j] = "";
                         delName = null;
                         break;
                        }
                    }
                }
                if (delName.Equals("Bed2(Clone)"))
                {
                for (int j = 0; j < 30; j++)
                {
                    if (Name[j].Equals("한샘몰 침대   649,000원\n"))
                    {
                        Name[j] = "";
                        delName = null;
                        break;
                    }
                }
                }

                //거실가구
                if (delName.Equals("Sofa_01(Clone)"))
                {
                for (int j = 0; j < 30; j++)
                {
                    if (Name[j].Equals("CJMall 소파   1,384,450원\n"))
                    {
                        Name[j] = "";
                        delName = null;
                        break;
                    }
                }
                }

                if (delName.Equals("Table_2(Clone)"))
                {
                for (int j = 0; j < 30; j++)
                {
                    if (Name[j].Equals("페라모 테이블   238,000원\n"))
                    {
                        Name[j] = "";
                        delName = null;
                        break;
                    }
                }
                }

                if (delName.Equals("Table_3(Clone)"))
                {
                for (int j = 0; j < 30; j++)
                {
                    if (Name[j].Equals("내추럴하우스 테이블   199,000원\n"))
                    {
                        Name[j] = "";
                        delName = null;
                        break;
                    }
                }
                }

                if (delName.Equals("Sofa_2(Clone)"))
                {
                for (int j = 0; j < 30; j++)
                {
                    if (Name[j].Equals("소파1975 소파   650,000원\n"))
                    {
                        Name[j] = "";
                        delName = null;
                        break;
                    }
                }
                }

                //주방가구
                if (delName.Equals("refr(Clone)"))
                {
                for (int j = 0; j < 30; j++)
                {
                    if (Name[j].Equals("지멘스 냉장고   3,341,900원\n"))
                    {
                        Name[j] = "";
                        delName = null;
                        break;
                    }
                }
                }

                if (delName.Equals("refr2(Clone)"))
                {
                for (int j = 0; j < 30; j++)
                {
                    if (Name[j].Equals("삼성 냉장고   1,059,000원\n"))
                    {
                        Name[j] = "";
                        delName = null;
                        break;
                    }
                }
                }

                //책상의자
                if (delName.Equals("Inv_Chair(Clone)"))
                {
                for (int j = 0; j < 30; j++)
                {
                    if (Name[j].Equals("한샘 목재의자   282,000원\n"))
                    {
                        Name[j] ="";
                        delName = null;
                        break;
                    }
                }
                }

                if (delName.Equals("Alu_Chair(Clone)"))
                {
                for (int j = 0; j < 30; j++)
                {
                    if (Name[j].Equals("블루밍홈 알미늄의자   74,300원\n"))
                    {
                        Name[j] = "";
                        delName = null;
                        break;
                    }
                }
                }

                //가전               

                if (delName.Equals("Tv_1(Clone)"))
                {
                for (int j = 0; j < 30; j++)
                {
                    if (Name[j].Equals("LG TV  - 원\n"))
                    {
                        Name[j] = "";
                        delName = null;
                        break;
                    }
                }
                }

                if (delName.Equals("Tv_2(Clone)"))
                {
                for (int j = 0; j < 30; j++)
                {
                    if (Name[j].Equals("삼성 TV  94,050원\n"))
                    {
                        Name[j] = "";
                        delName = null;
                        break;
                    }
                }
                }

                //기타
                if (delName.Equals("LampFloor(Clone)"))
                {
                for (int j = 0; j < 30; j++)
                {
                    if (Name[j].Equals("럭비스토어 스텐드  225,100원\n"))
                    {
                        Name[j] = "";
                        delName = null;
                        break;
                    }
                }
                }

                if (delName.Equals("IronMan(Clone)"))
                {
                for (int j = 0; j < 30; j++)
                {
                    if (Name[j].Equals("Figure City 아이언맨  559,000원\n"))
                    {
                        Name[j] = "";
                        delName = null;
                        break;
                    }
                }
                }

            
        }
        //이후 새로고침 감지 함수(i2)값을 변경해 초기화
        if (i2 == 1)
        {
            for (int i = 0; i < 30; i++)
            {
                if (i == 0)
                {
                    PriceText.text = "";                   
                }                
                if (Name[i] != null)
                {
                    PriceText.text += Name[i];


                }                 
            }
            i2 = 0;
            Total.text = "총 " + Price + " 원";
        } 
    }

    public void refresh()
    {
        //새로고침 버튼 누를시 새로고침 감지 함수 값 1 입력
        i2 = 1;
    }


}
