using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(SpriteRenderer))]
public class BGmove : MonoBehaviour {
    [SerializeField]
    private float speed = 0.3f;
    private SpriteRenderer spriteRenderer;
    private Material m_material;

	// Use this for initialization
	void Awake() {
        spriteRenderer = GetComponent<SpriteRenderer>();
        m_material = spriteRenderer.material;
	}
	
	// Update is called once per frame
	void Update () {
        m_material.mainTextureOffset = Vector2.up * Time.time * speed;
	}
}
