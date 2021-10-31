using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using Valve.VR;
using Valve.VR.Extras;

public class SwabLaerType : MonoBehaviour
{
    Hand hand;
    int check = 0;

    private float fDestroyTime = 2f;    //눌러야하는 시간 설정 2f = 2초
    private float fTickTime;        //누르고 있는 시간 감지



    // Start is called before the first frame update
    void Start()
    {

        hand = GetComponent<Hand>();    //Hand 컴포넌트 따옴
       
    }

    // Update is called once per frame
    void Update()
    {
        SteamVR_Input_Sources source = hand.handType;     

        fTickTime += Time.deltaTime;
        if (fTickTime >= fDestroyTime)
        {
            if (hand.grabGripAction[source].state == true && check == 0 && hand.grabPinchAction[source].state == false) //컨트롤러의 옆 버튼 눌렀을 때 + 포인터가 DistanceGrab 상태일때
            {

                gameObject.GetComponent<DistanceGrab>().enabled = false;
                gameObject.GetComponent<DelPointer>().enabled = true;
                gameObject.GetComponent<SteamVR_LaserPointer>().color = new Color(255, 0, 0);


                check = 1;

            }
            else if (hand.grabGripAction[source].state == true && check == 1 && hand.grabPinchAction[source].state == false) //컨트롤러의 옆 버튼 눌렀을 때 + 포인터가 DelPointer 상태일때
            {

                gameObject.GetComponent<DistanceGrab>().enabled = true;
                gameObject.GetComponent<DelPointer>().enabled = false;
                gameObject.GetComponent<SteamVR_LaserPointer>().color = new Color(0, 0, 0);

                check = 0;

            }
            
            fTickTime = 0;
        }

    }
}
