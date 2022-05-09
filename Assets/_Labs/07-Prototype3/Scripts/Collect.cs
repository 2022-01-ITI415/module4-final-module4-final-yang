using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{


    public GameObject Prompt1;
    public GameObject Prompt2;
    public GameObject Prompt3;
    public GameObject Prompt4;

    // Start is called before the first frame update
    void Start()
    {
        Prompt1.SetActive(true);
        Prompt2.SetActive(false);
        Prompt3.SetActive(false);
        Prompt4.SetActive(false);
        

    }
    void OnTriggerEnter(Collider player)
    {
        Destroy(gameObject);


        if (gameObject.name == "Wisp")
        {
            Prompt2.SetActive(true);
            Prompt1.SetActive(false);
        }

        if (gameObject.name == "Wisp2")
        {
            Prompt2.SetActive(false);
            Prompt3.SetActive(true);
        }

        if (gameObject.name == "Wisp3")
        {
            Prompt3.SetActive(false);
            Prompt4.SetActive(true);
        }
    }
        // Update is called once per frame
        void Update()
    {
        
    }
}
