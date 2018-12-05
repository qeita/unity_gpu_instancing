using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * https://teofilobd.github.io/2018/01/02/Unleash-your-GPU-instancing.html
 */
public class InstancingBasic : MonoBehaviour {

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

			yield return waitForInterval;
		}
	}
}
