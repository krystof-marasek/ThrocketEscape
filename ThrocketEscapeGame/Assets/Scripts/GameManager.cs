using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; 

    public int score=0;
    public Transform[] stagePositions; // Positions for each stage

    private void Awake()
    {
        // Check if the instance is null
        if (instance == null)
        {
            // Set the instance to this GameManager object
            instance = this;

            // Make the GameManager object persistent across scene changes
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // Destroy the duplicate GameManager object
            Destroy(gameObject);
        }
    }

    public void UpdateScoreAndPosition()
    {
       /*  if (playerScores.ContainsKey(playerId))
        {
            playerScores[playerId] += scoreIncrement;
        }
        else
        {
            playerScores[playerId] = scoreIncrement;

        } */
        score+=1; 
        Debug.Log(score);
       // MovePlayerToNextStage(playerId, nextStageIndex);
    }

/*     private void MovePlayerToNextStage(int playerId, int stageIndex)
    {
        GameObject player = FindPlayerById(playerId);
        if (player != null && stageIndex < stagePositions.Length)
        {
            player.transform.position = stagePositions[stageIndex].position;
        }
    }

    private GameObject FindPlayerById(int playerId)
    {
        // You might need a more sophisticated way to find players depending on your game structure
        return GameObject.Find("Player" + playerId);
    } */
}

