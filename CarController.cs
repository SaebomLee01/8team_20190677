using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CarController : MonoBehaviour
{
    float cMvSpeed = 30.0f;
    float cRotSpeed = 150.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float mv = Input.GetAxis("Vertical") * cMvSpeed * Time.deltaTime;
        float rot = Input.GetAxis("Horizontal") * cRotSpeed * Time.deltaTime;

        transform.Translate(0, 0, mv);
        transform.Rotate(0, rot, 0);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene("ClearScene");
        }
    }
}
