using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NematodeSchool : MonoBehaviour
{
    public GameObject prefab;

    public int ranLength = 20;
    public Material mat;
    [Range (1, 5000)]
    public int radius = 50;
    
    public int count = 10;

    // Start is called before the first frame update
    void Awake()
    {
        ranLength = Random.Range(5, 20);

        for(int i = 0; i<ranLength;i++)
        {
            GameObject wormSpheres = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            wormSpheres.transform.position = new Vector3(0, 0, i);
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
