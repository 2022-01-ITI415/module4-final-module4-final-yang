using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public GameObject Prompt1;
    public GameObject Prompt2;
    public GameObject Prompt3;
    public GameObject Prompt4;
    public GameObject Prompt5;
    public GameObject Prompt6;
    public GameObject Prompt7;
    public GameObject Prompt8;
    public GameObject Prompt9;
    public GameObject Prompt10;
    public GameObject Prompt11;
    public GameObject Prompt12;
    public GameObject Prompt13;
    public GameObject Prompt14;
    public GameObject Prompt15;
    public GameObject Prompt16;
    public GameObject Prompt17;
    public GameObject Prompt18;
    public GameObject Prompt19;
    public GameObject Prompt20;
    public GameObject Prompt21;
    public GameObject Prompt22;
    public GameObject Prompt23;
    public GameObject Prompt24;
    public GameObject Prompt25;
    public GameObject Prompt26;
    public GameObject Prompt27;
    public GameObject Prompt28;
    public GameObject Prompt29;
    public GameObject Prompt30;
    public GameObject Prompt31;
    public GameObject Prompt32;
    public GameObject Prompt33;
    public GameObject Prompt34;
    public GameObject Prompt35;
    public GameObject Prompt36;
    public GameObject Prompt37;
    public GameObject Prompt38;
    public GameObject Prompt39;
    public GameObject Prompt40;
    public GameObject Prompt41;
    public GameObject Prompt42;
    public GameObject Prompt43;
    public GameObject Prompt44;
    public GameObject Prompt45;
    public GameObject Prompt46;
    public GameObject Prompt47;
    public GameObject Prompt48;
    public GameObject Prompt49;
    public GameObject Prompt50;
    public GameObject Prompt51;

    //public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        Prompt1.SetActive(true);
        Prompt2.SetActive(false);
        Prompt3.SetActive(false);
        Prompt4.SetActive(false);
        Prompt5.SetActive(false);
        Prompt6.SetActive(false);
        Prompt7.SetActive(false);
        Prompt8.SetActive(false);
        Prompt9.SetActive(false);
        Prompt10.SetActive(false);
        Prompt11.SetActive(false);
        Prompt12.SetActive(false);
        Prompt13.SetActive(false);
        Prompt14.SetActive(false);
        Prompt15.SetActive(false);
        Prompt16.SetActive(false);
        Prompt17.SetActive(false);
        Prompt18.SetActive(false);
        Prompt19.SetActive(false);
        Prompt20.SetActive(false);
        Prompt21.SetActive(false);
        Prompt22.SetActive(false);
        Prompt23.SetActive(false);
        Prompt24.SetActive(false);
        Prompt25.SetActive(false);
        Prompt26.SetActive(false);
        Prompt27.SetActive(false);
        Prompt28.SetActive(false);
        Prompt29.SetActive(false);
        Prompt30.SetActive(false);
        Prompt41.SetActive(false);
        Prompt42.SetActive(false);
        Prompt43.SetActive(false);
        Prompt44.SetActive(false);
        Prompt45.SetActive(false);
        Prompt46.SetActive(false);
        Prompt47.SetActive(false);
        Prompt48.SetActive(false);
        Prompt49.SetActive(false);
        Prompt50.SetActive(false);
        Prompt51.SetActive(false);


    
    }
    void OnTriggerEnter(Collider other)
    {
        //Destroy(gameObject);
        //audioSource.Play();

        if (other.gameObject.name == "Wisp")
        {
            Prompt2.SetActive(true);
            Prompt1.SetActive(false);
        }
        if (other.gameObject.name == "Wisp2")
        {
            Prompt2.SetActive(false);
            Prompt3.SetActive(true);
        }
        if (other.gameObject.name == "Wisp3")
        {
            Prompt3.SetActive(false);
            Prompt4.SetActive(true);
        }
        if (other.gameObject.name == "Wisp4")
        {
            Prompt4.SetActive(false);
            Prompt5.SetActive(true);
        }
        if (other.gameObject.name == "Wisp5")
        {
            Prompt5.SetActive(false);
            Prompt6.SetActive(true);
        }
        if (other.gameObject.name == "Wisp6")
        {
            Prompt6.SetActive(false);
            Prompt7.SetActive(true);
        }
        if (other.gameObject.name == "Wisp7")
        {
            Prompt7.SetActive(false);
            Prompt8.SetActive(true);
        }
        if (other.gameObject.name == "Wisp8")
        {
            Prompt8.SetActive(false);
            Prompt9.SetActive(true);
        }
        if (other.gameObject.name == "Wisp9")
        {
            Prompt9.SetActive(false);
            Prompt10.SetActive(true);
        }
        if (other.gameObject.name == "Wisp10")
        {
            Prompt10.SetActive(false);
            Prompt11.SetActive(true);
        }

        if (other.gameObject.name == "Wisp11")
        {
            Prompt11.SetActive(false);
            Prompt12.SetActive(true);
        }
        if (other.gameObject.name == "Wisp12")
        {
            Prompt12.SetActive(false);
            Prompt13.SetActive(true);
        }
        if (other.gameObject.name == "Wisp13")
        {
            Prompt13.SetActive(false);
            Prompt14.SetActive(true);
        }
        if (other.gameObject.name == "Wisp14")
        {
            Prompt14.SetActive(false);
            Prompt15.SetActive(true);
        }
        if (other.gameObject.name == "Wisp15")
        {
            Prompt15.SetActive(false);
            Prompt16.SetActive(true);
        }
        if (other.gameObject.name == "Wisp16")
        {
            Prompt16.SetActive(false);
            Prompt17.SetActive(true);
        }
        if (other.gameObject.name == "Wisp17")
        {
            Prompt17.SetActive(false);
            Prompt18.SetActive(true);
        }
        if (other.gameObject.name == "Wisp18")
        {
            Prompt18.SetActive(false);
            Prompt19.SetActive(true);
        }
        if (other.gameObject.name == "Wisp19")
        {
            Prompt19.SetActive(false);
            Prompt20.SetActive(true);
        }
        if (other.gameObject.name == "Wisp20")
        {
            Prompt20.SetActive(false);
            Prompt21.SetActive(true);
        }

        if (other.gameObject.name == "Wisp21")
        {
            Prompt21.SetActive(false);
            Prompt22.SetActive(true);
        }
        if (other.gameObject.name == "Wisp22")
        {
            Prompt22.SetActive(false);
            Prompt23.SetActive(true);
        }
        if (other.gameObject.name == "Wisp23")
        {
            Prompt23.SetActive(false);
            Prompt24.SetActive(true);
        }
        if (other.gameObject.name == "Wisp24")
        {
            Prompt24.SetActive(false);
            Prompt25.SetActive(true);
        }
        if (other.gameObject.name == "Wisp25")
        {
            Prompt25.SetActive(false);
            Prompt26.SetActive(true);
        }
        if (other.gameObject.name == "Wisp26")
        {
            Prompt26.SetActive(false);
            Prompt27.SetActive(true);
        }
        if (other.gameObject.name == "Wisp27")
        {
            Prompt27.SetActive(false);
            Prompt28.SetActive(true);
        }
        if (other.gameObject.name == "Wisp28")
        {
            Prompt28.SetActive(false);
            Prompt29.SetActive(true);
        }
        if (other.gameObject.name == "Wisp29")
        {
            Prompt29.SetActive(false);
            Prompt30.SetActive(true);
        }
        if (other.gameObject.name == "Wisp30")
        {
            Prompt30.SetActive(false);
            Prompt31.SetActive(true);
        }

        if (other.gameObject.name == "Wisp31")
        {
            Prompt31.SetActive(false);
            Prompt32.SetActive(true);
        }
        if (other.gameObject.name == "Wisp32")
        {
            Prompt32.SetActive(false);
            Prompt33.SetActive(true);
        }
        if (other.gameObject.name == "Wisp33")
        {
            Prompt33.SetActive(false);
            Prompt34.SetActive(true);
        }
        if (other.gameObject.name == "Wisp34")
        {
            Prompt34.SetActive(false);
            Prompt35.SetActive(true);
        }
        if (other.gameObject.name == "Wisp35")
        {
            Prompt35.SetActive(false);
            Prompt36.SetActive(true);
        }
        if (other.gameObject.name == "Wisp36")
        {
            Prompt36.SetActive(false);
            Prompt37.SetActive(true);
        }
        if (other.gameObject.name == "Wisp37")
        {
            Prompt37.SetActive(false);
            Prompt38.SetActive(true);
        }
        if (other.gameObject.name == "Wisp38")
        {
            Prompt38.SetActive(false);
            Prompt39.SetActive(true);
        }
        if (other.gameObject.name == "Wisp39")
        {
            Prompt39.SetActive(false);
            Prompt40.SetActive(true);
        }
        if (other.gameObject.name == "Wisp40")
        {
            Prompt40.SetActive(false);
            Prompt41.SetActive(true);
        }

        if (other.gameObject.name == "Wisp41")
        {
            Prompt41.SetActive(false);
            Prompt42.SetActive(true);
        }
        if (other.gameObject.name == "Wisp42")
        {
            Prompt42.SetActive(false);
            Prompt43.SetActive(true);
        }
        if (other.gameObject.name == "Wisp43")
        {
            Prompt43.SetActive(false);
            Prompt44.SetActive(true);
        }
        if (other.gameObject.name == "Wisp44")
        {
            Prompt44.SetActive(false);
            Prompt45.SetActive(true);
        }
        if (other.gameObject.name == "Wisp45")
        {
            Prompt45.SetActive(false);
            Prompt46.SetActive(true);
        }
        if (other.gameObject.name == "Wisp46")
        {
            Prompt46.SetActive(false);
            Prompt47.SetActive(true);
        }
        if (other.gameObject.name == "Wisp47")
        {
            Prompt47.SetActive(false);
            Prompt48.SetActive(true);
        }
        if (other.gameObject.name == "Wisp48")
        {
            Prompt48.SetActive(false);
            Prompt49.SetActive(true);
        }
        if (other.gameObject.name == "Wisp49")
        {
            Prompt49.SetActive(false);
            Prompt50.SetActive(true);
        }
        if (other.gameObject.name == "Wisp50")
        {
            Prompt50.SetActive(false);
            Prompt51.SetActive(true);
        }
        if (other.gameObject.name == "Wisp51")
        {
            //Prompt40.SetActive(false);
            Prompt51.SetActive(false);
        }
    }
        // Update is called once per frame
        void Update()
    {
        
    }
}
