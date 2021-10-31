using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using Valve.VR;

public class DelPointer : MonoBehaviour
{
    public Transform pointer;
    public LayerMask thingsWeCanGrab;
    Renderer ObstacleRenderer;
    Renderer ObstacleRenderer2;
    private GameObject rig;
    public GameObject m_pointer;
    string objName;

    Hand hand;
    bool isAttached = false;
    GameObject attachedObject = null;
    Blank blank;


    private float fDestroyTime = 1f;
    private float fTickTime;

 
    void Start()
    {
        hand = GetComponent<Hand>();                                   
        rig = this.gameObject;
    }

    void Update()
    {

        RaycastHit hit;

        if (Physics.Raycast(pointer.position, pointer.forward, out hit, 10f, thingsWeCanGrab) && hand.currentAttachedObject == null)
        {
            Interactable interactable = hit.collider.gameObject.GetComponent<Interactable>();
            SteamVR_Input_Sources source = hand.handType;
         

            if (hand.grabGripAction[source].state == true && hand.grabPinchAction[source].state == true)    //트리거 버튼을 눌렀을때
            {

             
                   
                    if (interactable != null)   //삭제할 물체를 인식하고 PriceManager 스크립트의 Price값을 조절하고 삭제할 오브젝트의 명을 PriceManager에 보내줌
                    {
                        objName = interactable.gameObject.name;
                        PriceManager.delName = objName;
                        //침실가구
                        if (objName.Equals("bed1(Clone)"))
                        {
                        PriceManager.Price -= 359000;
 
                         }
                        if (objName.Equals("Bed2(Clone)"))
                        {
                        PriceManager.Price -= 649000;

                         }

                        //거실가구
                        if (objName.Equals("Sofa_01(Clone)"))
                        {
                        PriceManager.Price -= 1384450;
                          }
                        if (objName.Equals("Table_2(Clone)"))
                        {
                        PriceManager.Price -= 238000;

                         }
                        if (objName.Equals("Table_3(Clone)"))
                        {
                        PriceManager.Price -= 199000;
                         }
                        if (objName.Equals("Sofa_2(Clone)"))
                        {
                        PriceManager.Price -= 650000;
                        }

                        //주방가구
                        if (objName.Equals("refr(Clone)"))
                        {
                        PriceManager.Price -= 3341900;
                        }
                        if (objName.Equals("refr2(Clone)"))
                        {
                        PriceManager.Price -= 1059000;
                        }

                        //책상/의자
                        if (objName.Equals("Inv_Chair(Clone)"))
                        {
                        PriceManager.Price -= 282000;

                         }
                         if (objName.Equals("Alu_Chair(Clone)"))
                        {
                        PriceManager.Price -= 74300;
                         }

                         //가전
                         //LG전자 TV 단종 >> 0원 추후 변동사항있음
                         if (objName.Equals("Tv_2(Clone)"))
                         {
                        PriceManager.Price -= 94050;
                          }

                    //기타
                    if (objName.Equals("LampFloor(Clone)"))
                    {
                        PriceManager.Price -= 225100;
                    }
                    if (objName.Equals("IronMan(Clone)"))
                    {
                        PriceManager.Price -= 559000;
                    }

                        
                        PriceManager.i2 = 1;
                        Destroy(interactable.gameObject);
                     


                        // attachedObject = interactable.gameObject;
                        // isAttached = true;                  

                    }
                



            }
       


            blank = hit.collider.gameObject.GetComponentInChildren<Blank>();
            blank.gameObject.GetComponent<MeshRenderer>().enabled = true;
        }
        else
        {
            blank.gameObject.GetComponent<MeshRenderer>().enabled = false;
        }





    }
    private void LateUpdate()
    {
        //did we get an object to our hand during this update?
        if (isAttached)
        {
            //attach the object     
            hand.AttachObject(attachedObject, GrabTypes.Grip);
            attachedObject = null;
            isAttached = false;
        }
    }
}
