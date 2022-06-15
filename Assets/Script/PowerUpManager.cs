using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public Transform spawnArea; 
    public int maxPowerUpAmount; 
    public Vector2 powerUpAreaMin; 
    public Vector2 powerUpAreaMax; 
    public int spawnInterval; 
    public List<GameObject> powerUpTemplateList; 
    
    
 
    private List<GameObject> powerUpList; 
    private float timer; 
     
    
    private void Start() 
    { 
        powerUpList = new List<GameObject>(); 
        timer = 0; 
    } 
 
    private void Update() 
    { 
        timer += Time.deltaTime; 
 
        if (timer > spawnInterval) 
        { 
            GenerateRandomPowerUp(); 
            timer -= spawnInterval; 
        } 

        
    } 

    public void GenerateRandomPowerUp() //random spawn power up
    { 
        GenerateRandomPowerUp(new Vector2(Random.Range(powerUpAreaMin.x, powerUpAreaMax.x), Random.Range(powerUpAreaMin.y, powerUpAreaMax.y))); 
    } 

    public void GenerateRandomPowerUp(Vector2 position) //non random spawn power up
    { 
        if (powerUpList.Count >= maxPowerUpAmount)  //verif dan error handling jika power up melebihi batas jumlah
        { 
            RemovePowerUp(powerUpList[0]);
        } 
 
        if (position.x < powerUpAreaMin.x || 
            position.x > powerUpAreaMax.x || 
            position.y < powerUpAreaMin.y || 
            position.y > powerUpAreaMax.y) //verif dan error handling jika power up melebihi batas jumlah
        { 
            return; 
        } 
 
        int randomIndex = Random.Range(0, powerUpTemplateList.Count); 
 
        GameObject powerUp = Instantiate(powerUpTemplateList[randomIndex], new Vector3(position.x, position.y, powerUpTemplateList[randomIndex].transform.position.z), Quaternion.identity, spawnArea); 
        powerUp.SetActive(true); 
 
        powerUpList.Add(powerUp); 
    } 

    public void RemovePowerUp(GameObject powerUp) //Hapus power up ketika disentuh
    { 
        powerUpList.Remove(powerUp); 
        Destroy(powerUp); 
    } 
 
    public void RemoveAllPowerUp() //Eror handling untuk hapus semua power up
    { 
        while (powerUpList.Count > 0) 
        { 
            RemovePowerUp(powerUpList[0]); 
        } 
    } 
}
