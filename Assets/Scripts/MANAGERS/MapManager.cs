using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    public GameObject[] maps;
    public Transform[] weaponSpawnPoints;
    public GameObject[] weaponsPrefabs; 

    public void LoadMap(int round)
    {
        int mapIndex = (round - 1) % maps.Length;
        GameObject instantiatedMap = Instantiate(maps[mapIndex], Vector3.zero, Quaternion.identity);

        //spawn de armas 
        SpawnWeapons(weaponsPrefabs, weaponSpawnPoints);
    }

    void SpawnWeapons(GameObject[] weapons, Transform[] spawnPoints)
    {
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            //escoge un arma aleatoria de la lista 
            GameObject weaponPrefab = weapons[Random.Range(0, weapons.Length)];

            //instancia el arma en el punto de spawn actual
            GameObject instantiatedWeapon = Instantiate(weaponPrefab, spawnPoints[i].position, Quaternion.identity);

            //ajustes adicionales según necesites (rotación, escala, componentes específicos, etc.)
            //instantiatedWeapon.transform.rotation = Quaternion.Euler(...);
            //instantiatedWeapon.GetComponent<Weapon>().Initialize(...);
        }
    }
}

