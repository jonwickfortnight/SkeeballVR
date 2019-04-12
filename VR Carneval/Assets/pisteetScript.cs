using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pisteetScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static int skeeballPisteet;
    TextMeshPro textmeshprokomponentti;
    void Start()
    {
        textmeshprokomponentti = GetComponent<TextMeshPro>();
        skeeballPisteet = 0;
    }

    // Update is called once per frame
    void Update()
    {
        textmeshprokomponentti.SetText(skeeballPisteet.ToString());
    }
}
