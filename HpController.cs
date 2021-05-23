using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HpController : MonoBehaviour
{
    GameObject hp;
    
    // Start is called before the first frame update
    void Start()
    {
        hp = GameObject.Find("HP");
    }

    public void HpControl()
    {
        hp.GetComponent<Image>().fillAmount -= 0.2f;
        if (hp.GetComponent<Image>().fillAmount <= 0)
        {
            SceneManager.LoadScene("OverScene");
        }
    }

    public void HpControl2()
    {
        hp.GetComponent<Image>().fillAmount += 0.1f;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
