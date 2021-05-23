using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PotionControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject hp = GameObject.Find("HPControl");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        GameObject hp = GameObject.Find("HPControl");
        if (other.gameObject.tag == "Player")
        {
            hp.GetComponent<HpController>().HpControl2();
            Destroy(gameObject);
        }
    }
}
