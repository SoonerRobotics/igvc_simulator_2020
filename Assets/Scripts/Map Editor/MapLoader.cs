﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MapLoader : MonoBehaviour
{
    public void Load(MapEditor.CustomMap map, List<PrefabScriptableObject> prefabReference)
    {
        int loadedObjects = 0;
        foreach(var obj in map.mapObjects)
        {
            var selectedPrefab = prefabReference.Where(x => x.Identifier.Equals(obj.prefabIdentifier)).FirstOrDefault();
            if(selectedPrefab == null)
            {
                Debug.LogWarning($"Failed to load prefab: {obj.prefabIdentifier} at {obj.position}");
            } else
            {
                GameObject newObject = Instantiate(selectedPrefab.Reference);
                newObject.transform.position = obj.position;
                newObject.transform.rotation = Quaternion.Euler(obj.rotation);
                newObject.transform.localScale = obj.scale;
                loadedObjects++;
            }
        }

        Debug.Log($"Map {map.mapName} loaded. With {loadedObjects}/{map.mapObjects.Count} objects successfully created.");
    }
}