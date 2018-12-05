using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstancingProperty : MonoBehaviour {

	public GameObject m_ObjectPrefab;
	public float m_SpawningInterval = 1f;

	// Use this for initialization
	void Start () {
		StartCoroutine( SpawnObjects() );		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator SpawnObjects(){
		WaitForSeconds waitForInterval = new WaitForSeconds(m_SpawningInterval);
		while(true){
			GameObject go = Instantiate(m_ObjectPrefab, transform);
			go.transform.parent = transform;
			go.GetComponent<Rigidbody>().AddForce(
				new Vector3(
					Random.Range(0f, 100f),
					Random.Range(0f, 100f),
					Random.Range(0f, 100f)
				)
			);

			// add
			ObjectPropertyHandler oph = go.AddComponent<ObjectPropertyHandler>();
			oph.m_Color = new Color(
				Random.Range(0f, 1f),
				Random.Range(0f, 1f),
				Random.Range(0f, 1f),
				1f
			);

			yield return waitForInterval;
		}
	}
}
