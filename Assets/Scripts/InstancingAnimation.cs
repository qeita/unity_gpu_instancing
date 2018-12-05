using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstancingAnimation : MonoBehaviour {
    public int instanceCount = 100000;
    public GameObject m_ObjectPrefab;

    void Start() {
        for(int i = 0; i < instanceCount; i++){
            GenInstance();
        }
    }

    void Update() {
    }

    private void GenInstance() {
        Instantiate(
            m_ObjectPrefab,
            new Vector3(
                Random.Range(-10f, 10f),
                0f,
                Random.Range(-10f, 10f)
            ),
            Quaternion.Euler(90, 0, 0)
        );
    }

}
