using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionMaker : MonoBehaviour
{
    public GameObject ptPrefab;
    float interval = 3.0f;
    float delta = 0;

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > interval)
        {
            delta = 0;
            GameObject Bottle_Health = Instantiate(ptPrefab);
            int x = Random.Range(70, 200);
            int z = Random.Range(130, 150);
            Bottle_Health.transform.position = new Vector3(x, 2, z);
        }
    }

}
