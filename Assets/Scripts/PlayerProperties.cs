using UnityEngine;
using System.Collections;

public class PlayerProperties : MonoBehaviour {

    private static string playerClass = "";
    private static string player0Name = "";
    private static string player1Name = "";
    private static string player2Name = "";
    private static string player3Name = "";
    private static string player4Name = "";
    private static string player5Name = "";
    private static string startMonth = "";
    private static int money = 0;
    private static int food = 0;
    private static int bullets = 0;
    private static int guns = 0;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public string getPlayerClass() {
        return playerClass;
    }

    public void setPlayerClass(string className) {
        if(className.Equals("soldier") ||
            className.Equals("farmer") ||
            className.Equals("shaman") ||
            className.Equals("teacher") ||
            className.Equals("clanLeader")) {
            playerClass = className;
        }
    }

    public string getPlayer0Name() {
        return player0Name;
    }

    public string getPlayer1Name() {
        return player1Name;
    }

    public string getPlayer2Name() {
        return player2Name;
    }

    public string getPlayer3Name() {
        return player3Name;
    }

    public string getPlayer4Name() {
        return player4Name;
    }

    public string getPlayer5Name() {
        return player5Name;
    }

    public void setPlayer0Name(string name) {
        player0Name = name;
    }

    public void setPlayer1Name(string name) {
        player1Name = name;
    }

    public void setPlayer2Name(string name) {
        player2Name = name;
    }

    public void setPlayer3Name(string name) {
        player3Name = name;
    }

    public void setPlayer4Name(string name) {
        player4Name = name;
    }

    public void setPlayer5Name(string name) {
        player5Name = name;
    }

    public int getMoney() {
        return money;
    }

    public void setMoney(int moneyIn) {
        money += moneyIn;

        if (money < 0) {
            money = 0;
        } 
    }

    public int getFood() {
        return food;
    }

    public void setFood(int foodIn) {
        food += foodIn;

        if (food < 0)
        {
            food = 0;
        }
    }

    public int getBullets() {
        return food;
    }

    public void setBullets(int bulletsIn) {
        bullets += bulletsIn;

        if (bullets < 0)
        {
            bullets = 0;
        }
    }

    public int getGuns() {
        return food;
    }

    public void setGuns(int gunsIn) {
        guns += gunsIn;

        if (guns < 0)
        {
            guns = 0;
        }
    }
}
