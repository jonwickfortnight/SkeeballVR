using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class resetScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float skeeballAjastin;
    public bool nollaus;
    public TextMeshPro TimeText;
    public static bool peliKaynnissa;
    void Start()
    {
        skeeballAjastin = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (skeeballAjastin < 0)
        {
            peliKaynnissa = false;
        }
        if (peliKaynnissa)
        {
            TimeText.text = Mathf.Round(skeeballAjastin).ToString();
            skeeballAjastin -= Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        peliKaynnissa = true;
        skeeballAjastin = 60;
        pisteetScript.skeeballPisteet = 0;
    }
}
