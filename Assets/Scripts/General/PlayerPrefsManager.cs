using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPrefsManager : MonoBehaviour {

	const string MASTER_VOLUME_KEY = "master_volume";
	const string LEVEL_UNLOCK_KEY = "level_unlocked_";


	const string PLAYER_CREATED_KEY = "player_created";

	// Player Information
	const string PLAYER_NAME_KEY = "player_name"; // Implement later
	const string PLAYER_CLASS_KEY = "player_class";
	const string PLAYER_LEVEL_KEY = "player_level";
	const string PLAYER_EXP_KEY = "player_exp";
	const string PLAYER_REQUIRED_EXP_KEY = "player_required_exp";
	const string PLAYER_MAX_HP_KEY = "player_max_hp";
	const string PLAYER_MAX_MANA_KEY = "player_max_mana";
	const string PLAYER_STR_KEY = "player_strength";
	const string PLAYER_INT_KEY = "player_intelligence";
	const string PLAYER_SPD_KEY = "player_speed";
	const string PLAYER_DEF_KEY = "player_defense";

	const string PLAYER_STAT_POINTS_KEY = "player_stat_points";

	// VOLUME 
	public static void SetMasterVolume(float volume){
		if(volume > 0f && volume <1f){
			PlayerPrefs.SetFloat(MASTER_VOLUME_KEY,volume);
		}else{
			Debug.LogError("volume out of range");
		}
	}

	public static float GetMasterVolume(){
		return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
	}



	// LEVEL MANAGER
	public static void UnlockLevel(int level){
		if (level <= SceneManager.sceneCountInBuildSettings - 1){
			PlayerPrefs.SetInt(LEVEL_UNLOCK_KEY + level.ToString(), 1); // Use 1 for true
		}else{
			Debug.LogError("song array out of bounds.");
		}
	}


	// Sets/Gets if a character was created or not
	public static void SetPlayerCreated(int created){
		PlayerPrefs.SetInt(PLAYER_CREATED_KEY,created); // 1 for true
	}

	public static int GetPlayerCreated(){
		return PlayerPrefs.GetInt(PLAYER_CREATED_KEY); // 1 for true
	}




	/**
		*********************
		*****PLAYER STATS****
		*********************
	**/
	public static void SetPlayerLevel(int level){
		PlayerPrefs.SetInt(PLAYER_LEVEL_KEY,level); 
	}

	public static int GetPlayerLevel(){
		return PlayerPrefs.GetInt(PLAYER_LEVEL_KEY); 
	}

	public static void SetPlayerEXP(int exp){
		PlayerPrefs.SetInt(PLAYER_EXP_KEY,exp); 
	}

	public static int GetPlayerEXP(){
		return PlayerPrefs.GetInt(PLAYER_EXP_KEY); 
	}

	public static void SetPlayerMaxHP(int hp){
		PlayerPrefs.SetInt(PLAYER_MAX_HP_KEY,hp); 
	}

	public static int GetPlayerMaxHP(){
		return PlayerPrefs.GetInt(PLAYER_MAX_HP_KEY); 
	}

	public static void SetPlayerMaxMana(int mana){
		PlayerPrefs.SetInt(PLAYER_MAX_MANA_KEY,mana); 
	}

	public static int GetPlayerMaxMana(){
		return PlayerPrefs.GetInt(PLAYER_MAX_MANA_KEY); 
	}

	public static void SetPlayerStrength(int str){
		PlayerPrefs.SetInt(PLAYER_STR_KEY,str); 
	}

	public static int GetPlayerStrength(){
		return PlayerPrefs.GetInt(PLAYER_STR_KEY); 
	}

	public static void SetPlayerIntelligence(int intel){
		PlayerPrefs.SetInt(PLAYER_INT_KEY,intel); 
	}

	public static int GetPlayerIntelligence(){
		return PlayerPrefs.GetInt(PLAYER_INT_KEY); 
	}

	public static void SetPlayerSpeed(int speed){
		PlayerPrefs.SetInt(PLAYER_SPD_KEY,speed); 
	}

	public static int GetPlayerSpeed(){
		return PlayerPrefs.GetInt(PLAYER_SPD_KEY); 
	}

	public static void SetPlayerDefense(int def){
		PlayerPrefs.SetInt(PLAYER_DEF_KEY,def); 
	}

	public static int GetPlayerDefense(){
		return PlayerPrefs.GetInt(PLAYER_DEF_KEY); 
	}

	public static void SetRequiredEXP(int exp){
		PlayerPrefs.SetInt(PLAYER_REQUIRED_EXP_KEY,exp); 
	}

	public static int GetRequiredEXP(){
		return PlayerPrefs.GetInt(PLAYER_REQUIRED_EXP_KEY); 
	}

	public static void SetStatPoints(int points){
		PlayerPrefs.SetInt(PLAYER_STAT_POINTS_KEY,points); 
	}

	public static int GetStatPoints(){
		return PlayerPrefs.GetInt(PLAYER_STAT_POINTS_KEY); 
	}

	public static void SetPlayerClass(int classNum){
		PlayerPrefs.SetInt(PLAYER_CLASS_KEY, classNum); 
	}

	public static int GetPlayerClass(){
		return PlayerPrefs.GetInt(PLAYER_CLASS_KEY); 
	}


}
