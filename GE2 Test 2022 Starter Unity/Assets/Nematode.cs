using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nematode : MonoBehaviour
{

    public int ranLength = 20;
    public Material mat;
    

    public int length = 5;

    public Material material;

    void Awake()
    {
        

        for (int i = 1; i < ranLength; i++)
        {
            
            GameObject wormSpheres = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            MeshRenderer mesh = wormSpheres.GetComponent<MeshRenderer>();
            
            wormSpheres.transform.position = new Vector3(0, 0, i * 2);
            wormSpheres.transform.SetParent(transform);
            float colorval = (1f / length * (i-1));
            mesh.material.color = Color.HSVToRGB(colorval, 1, 1);




            if( i <= 1)
            {
                wormSpheres.AddComponent<Boid>();
                wormSpheres.AddComponent<ObstacleAvoidance>();
                wormSpheres.AddComponent<Constrain>();
                wormSpheres.AddComponent<NoiseWander>();
            }
        }

        


    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
