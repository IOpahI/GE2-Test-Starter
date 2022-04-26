using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NematodeSchool : MonoBehaviour
{
    public GameObject prefab;

    [Range (1, 5000)]
    public int radius = 50;
    
    public int count = 10;

    // Start is called before the first frame update
    void Awake()
    {
        for(int i = 0; i<count; i++)
        {

            Vector3 position = Random.insideUnitSphere * radius;
            float randomAngle = Random.Range(0f, 360f);
            Quaternion angle = Quaternion.Euler(0f, randomAngle, 0f);
            Instantiate(prefab, position,angle);
        }

    }


}
