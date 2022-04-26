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
       
        ranLength = Random.Range(5, 20);

        for (int i = 0; i < ranLength; i++)
        {

            GameObject wormSpheres = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            MeshRenderer mesh = wormSpheres.GetComponent<MeshRenderer>();

            if (i <= 0)
            {
                wormSpheres.AddComponent<Boid>();
                wormSpheres.AddComponent<ObstacleAvoidance>();
                wormSpheres.AddComponent<Constrain>();
                wormSpheres.AddComponent<NoiseWander>();
            }

            float colorval = 1f / length * i;
            mesh.material.color = Color.HSVToRGB(colorval, 1f, 1f);


            wormSpheres.transform.SetParent(transform);
            wormSpheres.transform.position = new Vector3(0, 0, i);
            wormSpheres.transform.localScale += new Vector3(0, 1, 1);



        }
    }

}
