using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This class separated from real instanciation to have posibility to improve generation with procedural pickables spawning
//But the proplem is that it is really needs player to move only by y axis what makes it not reusable, but, at least it fits here best
public class ChunkGen : MonoBehaviour //1d chunk generator
{
    public Action<float> GenerateChunk;
    public Action<float> DestroyChunk;

    [SerializeField]private Transform trackedObj;

    [SerializeField]private float chunkSize, firstChunkPos;
    [SerializeField]private int chunksInFront, chunksBehind;

    private int currentChunk;

    private void Start() {
        trackedObj = trackedObj != null ? trackedObj : Camera.main.transform;
    }

    private void FixedUpdate() {
        var chunk = (int)((transform.position.y - firstChunkPos) / chunkSize);
        if (chunk == currentChunk) return;

    }

    private void Generate(int chunk) {
        GenerateChunk?.Invoke((chunk + chunksInFront) * chunkSize);
        DestroyChunk?.Invoke((chunk - chunksBehind - 1) * chunkSize);
    }
}
