using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPropertyHandler : MonoBehaviour {

	public Color m_Color;

	// Use this for initialization
	void Start () {
		// Create property block and set to the mesh.
		MaterialPropertyBlock propertyBlock = new MaterialPropertyBlock();
		propertyBlock.SetColor("_Color", m_Color);
		GetComponent<MeshRenderer>().SetPropertyBlock( propertyBlock );
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
