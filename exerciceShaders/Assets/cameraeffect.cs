using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class cameraeffect : MonoBehaviour {
    private Material material;
	// Use this for initialization
	void Start () {
        material = new Material(Shader.Find("Hidden/ShaderImage"));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, material);
    }
}
