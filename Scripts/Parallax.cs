using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private MeshRenderer meshrenderer;
    public float animationSpeed = 1f;

    private void Awake() {
        meshrenderer = GetComponent<MeshRenderer>();
    }

    private void Update() {
        //cho background đi cảnh
        meshrenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);
    }
}
