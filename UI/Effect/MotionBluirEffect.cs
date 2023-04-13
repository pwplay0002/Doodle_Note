using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionBluirEffect : MonoBehaviour
{
    [SerializeField]
    private Material material;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, material);
    }
}
