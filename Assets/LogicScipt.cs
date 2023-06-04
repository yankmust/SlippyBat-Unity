using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScipt : MonoBehaviour
{
   public int playerScore;
   public Text scoreText;
   public GameObject gameOverScreen;
   public Text highScoreText;
   public int highScore;
   
   [ContextMenu("Increase Score")]
  public void addScore(int scoreToAdd){
    playerScore += scoreToAdd;
    scoreText.text = playerScore.ToString();
    checkHighScore();
   }

   public void restartGame(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);

   }
   void Start(){
    updateHighScore();
   }

   public void gameOver(){
    gameOverScreen.SetActive(true);
    

   }
   public void checkHighScore(){
    
      if(playerScore > PlayerPrefs.GetInt("highScore", 0)){
       
        PlayerPrefs.SetInt("highScore", playerScore);
        updateHighScore();
        
        
    }

   }
   public void updateHighScore(){
    highScoreText.text = "High Score: "+PlayerPrefs.GetInt("highScore",0);
   }

}
