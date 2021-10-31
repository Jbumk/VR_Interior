using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using Valve.VR;
using Valve.VR.Extras;


public class Tomusic : MonoBehaviour
{
    public GameObject MusicPoint;
    public GameObject P;
    public GameObject BackPoint;
    public GameObject Cav;

    //그립버튼

    int NowPlaceBool = 0;
    Hand hand;

    void Start()
    {

        hand = GetComponent<Hand>();

    }
    public void ToBack()
    {
        P.transform.position = BackPoint.transform.position;
        NowPlaceBool = 0;
    }

    void Update()
    {

        //스왑
        SteamVR_Input_Sources source = hand.handType;

        {
            if (hand.grabGripAction[source].state == true && hand.grabPinchAction[source].state == false)   //컨트롤러 옆의 버튼 눌렀을때 MP3컨트롤 위치로 이동
            {

                NowPlaceBool = 1;
                Cav.SetActive(true);
                P.transform.position = MusicPoint.transform.position;
            }






            ////컨트롤러 옆의 버튼 눌렀을때 원래의 위치로 이동
            if (NowPlaceBool == 0)
            {
                BackPoint.transform.position = P.transform.position;
            }
            else { }


        }
    }
}
    
