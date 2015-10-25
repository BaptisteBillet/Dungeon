using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BreakMaterial : MonoBehaviour {

    public List<Texture> m_TextureList = new List<Texture>();

    private Renderer m_Renderer;

	// Use this for initialization
	void Start () {

        //Get the Material
        m_Renderer = GetComponent<Renderer>();

	}
	
    public void SetTexture(int level)
    {
        m_Renderer.material.mainTexture = m_TextureList[level];
    }

}
