using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomTipGenerator : MonoBehaviour
{
    [SerializeField]
    Material[] skinMat;

    
    [SerializeField]
    Material[] Colors;
    

    [SerializeField]
    GameObject hat, face, eye1, eye2;

    int shinRand, hatRand, eyeRand;
    Color eyeRandColor;

    void Start()
    {
        randomGenerate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void randomGenerate()
    {
        shinRand = Random.Range(0, skinMat.Length);
        hatRand = Random.Range(0, Colors.Length);
        eyeRand = Random.Range(0, Colors.Length);
        eyeRandColor = new Color(
            Random.Range(0, 255),
            Random.Range(0, 255),
            Random.Range(0, 255)
        );
        face.GetComponent<MeshRenderer>().material = skinMat[shinRand];
        hat.GetComponent<MeshRenderer>().material = Colors[hatRand];
        eye1.GetComponent<MeshRenderer>().material = Colors[eyeRand];
        eye2.GetComponent<MeshRenderer>().material = Colors[eyeRand];
    }
}
