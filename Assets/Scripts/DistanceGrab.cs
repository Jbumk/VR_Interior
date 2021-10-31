using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using Valve.VR;

public class DistanceGrab : MonoBehaviour
{
    public Transform pointer;
    public LayerMask thingsWeCanGrab; 
    Renderer ObstacleRenderer;
    Renderer ObstacleRenderer2;
    private GameObject rig;
    public GameObject m_pointer;


    Hand hand;  
    bool isAttached = false;    //손에 쥐고 있는지 확인
    GameObject attachedObject = null;   //손에 있는 물체
    Blank blank; //비어있음


    void Start()
    {
        hand = GetComponent<Hand>();      //hand 스크립트 가져옴
        rig = this.gameObject;  // 행동의 주체인 플레이어
    }

    void Update()
    {

        RaycastHit hit;

        if (Physics.Raycast(pointer.position, pointer.forward, out hit, 10f, thingsWeCanGrab) && hand.currentAttachedObject == null)    // 포인터가 10f 거리 내의 thingsWeCanGrab레이어의 물체를 가리킬때&&손에 물체가 있는가?
        {
            Interactable interactable = hit.collider.gameObject.GetComponent<Interactable>();
            SteamVR_Input_Sources source = hand.handType;
  

            if (hand.grabGripAction[source].state == true && hand.grabPinchAction[source].state == true)    //트리거 버튼을 눌렀을때
            {

           
                if (interactable != null)   //현재 손에 충돌하는 물체가 없을때
                {
                    interactable.transform.LookAt(transform);   
                    interactable.gameObject.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 300, ForceMode.Force);
                    attachedObject = interactable.gameObject;
                    isAttached = true;  //46L ~ 49L 손에 물체를 자신의 앞까지 끌어오고 손에 잡는다

                   
                    ObstacleRenderer = attachedObject.gameObject.GetComponent<MeshRenderer>();          
                    Material Mat = ObstacleRenderer.material;                   
                    Color matColor = Mat.color;                    
                    matColor.a = 0.1f;                    
                    Mat.color = matColor;
                    ObstacleRenderer2 = m_pointer.gameObject.GetComponent<LineRenderer>();
                    Material Mat2 = ObstacleRenderer2.material;
                    Color matColor2 = Mat2.color;
                    matColor2.a = 0f;
                    Mat2.color = matColor2; //52L ~ 61L 가져온 물체의 Material을 반 투명화 한다
                   
                }
               

            }
            if (interactable == null)   //손에 물체가 없을경우 이전에 반투명처리한 물체의 투명도를 돌려놓는다
            {

                Material Mat = ObstacleRenderer.material;  
                Color matColor = Mat.color;
                matColor.a = 1f;
                Mat.color = matColor;
                Material Mat2 = ObstacleRenderer2.material;
                Color matColor2 = Mat2.color;
                matColor2.a = 1f;
                Mat2.color = matColor2;


            }


            blank = hit.collider.gameObject.GetComponentInChildren<Blank>();
            blank.gameObject.GetComponent<MeshRenderer>().enabled = true;
        }
        else
        {
           
        }





    }
    private void LateUpdate()
    {
        //did we get an object to our hand during this update?
        //업데이트중 손에 물제가 잡혔나?
        if (isAttached)
        {
            //attach the object
            //해당 object를 손에 붙힌다
            hand.AttachObject(attachedObject, GrabTypes.Grip);
            attachedObject = null;
            isAttached = false;
        }
    }
}
