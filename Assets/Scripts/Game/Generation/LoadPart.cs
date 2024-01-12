using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LoadPart : MonoBehaviour
{
    [SerializeField]private ChunkGen generator;
    [SerializeField]private string partsFolder;

    private GameObject[] _parts;
    private readonly List<GameObject> _loadedParts = new();

    private void Awake() {
        generator = generator != null ? generator : GetComponent<ChunkGen>();
        generator.GenerateChunk += Load;
        generator.DestroyChunk += Unload;

        _parts = Resources.LoadAll<GameObject>(partsFolder);
    }

    public void Load(float pos) {
        var loaded = Instantiate(_parts[Random.Range(0, _parts.Length)], new Vector3(0, pos, 0), Quaternion.identity);
        _loadedParts.Add(loaded);
    }

    public void Unload(float _) {
        var last = _loadedParts[0];
        _loadedParts.RemoveAt(0);
        Destroy(last);
    }
}
