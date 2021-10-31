using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testtotest : MonoBehaviour
{
   public GameObject jt;
    Renderer ObstacleRenderer;
    // Start is called before the first frame update
    void Start()
    {
        ObstacleRenderer = jt.gameObject.GetComponent<MeshRenderer>();

        Material Mat = ObstacleRenderer.material;
        Color matColor = Mat.color;
        matColor.a = 0.5f;
        Mat.color = matColor;
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
