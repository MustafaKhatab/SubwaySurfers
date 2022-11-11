
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;




public class generate : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject myPrefab;
    public int ability;
    public static bool delete;
    public static bool deleteall;
    public bool LeftAn;
    public bool RightAn;
    public bool JumpAn;
    public bool SpecialAn;
    public bool invincible;
    public int randomZ;
    public int randomS;
    public static int health;
    public static int score;
    public float[] chooseZ;
    public float[] chooseZ2;
    public TMP_Text ab;
    public TMP_Text sco;
    public TMP_Text hlth;
    public AudioSource collect;
    public AudioSource hit;
    // Start is called before the first frame update
    void Start()
    {
        LeftAn = false;
        RightAn = false; 
        JumpAn = false;
        SpecialAn = false;

        invincible = false;
        delete = false;
        chooseZ = new float[3];
        health = 5;
        score = 0;
        ability = 10 ;
        chooseZ[0] = -3f;
        chooseZ[1] = 0;
        chooseZ[2] = 3f;
        chooseZ2 = new float[2];
        chooseZ2[0] = -1.5f;
        chooseZ2[1] = 1.5f;
        
        
        InvokeRepeating("GenerateObs", 0f, 2f);
        rb = GetComponent<Rigidbody>();
 

    }

    private void Update()
    {
        
        delete = false;
        deleteall = false;
        if (!PauseMenu.GameIsPaused && !GameOver.GameIsPaused) { 
        if ((Input.GetKeyDown("a") | Input.GetKeyDown("left")) | LeftAn  && this.transform.position.z > -4)
        {
            this.transform.position = this.transform.position + new Vector3(0, 0, -1f);
            LeftAn = false;

        }
        if ((Input.GetKeyDown("d") | Input.GetKeyDown("right")) | RightAn && this.transform.position.z < 4)
        {
            this.transform.position = this.transform.position + new Vector3(0, 0, 1f);
            RightAn = false;
        }
        if (Input.GetKeyDown("space") | JumpAn && this.transform.position.y == 0.5 && ability > 0)
        {
            rb.AddForce(new Vector3(0f, 8f, 0f), ForceMode.Impulse);
            ability -= 1;
            JumpAn = false;

        }
        if (Input.GetKeyDown("q") | SpecialAn && ability >= 5) {
            
            delete = true;
            ability -= 5;
            SpecialAn = false;

            }
            if (Input.GetKeyDown("h") ) {
            health--;

        }if (Input.GetKeyDown("g") ) {
            health++;

        }if (Input.GetKeyDown("k") ) {
            ability--;

        }if (Input.GetKeyDown("j") ) {
            ability++;

        }
        if (Input.GetKeyDown("j") ) {
            ability++;

        }if (Input.GetKeyDown("l") ) {
            invincible=!invincible;

        }
        
        }
        
        if (PauseMenu.Restartgame == true)
        {
            deleteall = true;
            health = 5;
            ability = 10;
            score = 0;
            PauseMenu.Restartgame = false;

        }
        if (GameOver.Restartgame == true)
        {
            deleteall = true;
            health = 5;
            ability = 10;
            score = 0;
            GameOver.Restartgame = false;

        }
        sco.text = "Score : " + score;
        hlth.text = "Health : " + health;
        ab.text = "Ability : " + ability;
    }
    void GenerateObs()
    {
        randomS = Random.Range(0, 4);


        if (randomS==0)
        {
            GameObject obstacle = ObjectPool.SharedInstance.GetPooledObject();
            if (obstacle != null)
            {
                randomZ = Random.Range(0, 3);
                obstacle.transform.position = new Vector3(15, 0.5f, chooseZ[randomZ]);
                obstacle.transform.rotation = Quaternion.identity;
                obstacle.SetActive(true);
            }
        }
            

        else if (randomS == 1)
        {

            GameObject obstacle = ObjectPool2.SharedInstance.GetPooledObject();
            if (obstacle != null)
            {
                randomZ = Random.Range(0, 2);
                obstacle.transform.position = new Vector3(15, 0.5f, chooseZ2[randomZ]);
                obstacle.transform.rotation = Quaternion.identity;
                obstacle.SetActive(true);
            }
           
        }
        else if (randomS == 2)
        {
            GameObject obstacle = ObjectPool3.SharedInstance.GetPooledObject();
            if (obstacle != null)
            {
                obstacle.transform.position = new Vector3(15, 0.5f, 0);
                obstacle.transform.rotation = Quaternion.identity;
                obstacle.SetActive(true);
            }
            
        }
        else
        {
            int randomOrb1 = Random.Range(0, 3);
            if (randomOrb1 == 0)
            {
                GameObject healthorb = ObjectPool4.SharedInstance.GetPooledObject();
                if (healthorb != null)
                {
                    healthorb.transform.position = new Vector3(15, 1, -3);
                    healthorb.transform.rotation = Quaternion.identity;
                    healthorb.SetActive(true);
                }
            }
            else if (randomOrb1 == 1)
            {
                GameObject abilityorb = ObjectPool5.SharedInstance.GetPooledObject();
                if (abilityorb != null)
                {
                    abilityorb.transform.position = new Vector3(15, 1, -3);
                    abilityorb.transform.rotation = Quaternion.identity;
                    abilityorb.SetActive(true);
                }
            }
            int randomOrb2 = Random.Range(0, 3);
            if (randomOrb2 == 0)
            {
                GameObject healthorb = ObjectPool4.SharedInstance.GetPooledObject();
                if (healthorb != null)
                {
                    healthorb.transform.position = new Vector3(15, 1, 0);
                    healthorb.transform.rotation = Quaternion.identity;
                    healthorb.SetActive(true);
                }
            }
            else if (randomOrb2 == 1)
            {
                GameObject abilityorb = ObjectPool5.SharedInstance.GetPooledObject();
                if (abilityorb != null)
                {
                    abilityorb.transform.position = new Vector3(15, 1f, 0);
                    abilityorb.transform.rotation = Quaternion.identity;
                    abilityorb.SetActive(true);
                }
            }
            int randomOrb3 = Random.Range(0, 3);
            if (randomOrb3 == 0)
            {
                GameObject healthorb = ObjectPool4.SharedInstance.GetPooledObject();
                if (healthorb != null)
                {
                    healthorb.transform.position = new Vector3(15, 1f, 3);
                    healthorb.transform.rotation = Quaternion.identity;
                    healthorb.SetActive(true);
                }
            }
            else if (randomOrb3 == 1)
            {
                GameObject abilityorb = ObjectPool5.SharedInstance.GetPooledObject();
                if (abilityorb != null)
                {
                    abilityorb.transform.position = new Vector3(15, 1f, 3);
                    abilityorb.transform.rotation = Quaternion.identity;
                    abilityorb.SetActive(true);
                }
            }
        }
    }

    void FixedUpdate()
    {
       

    }
    public void Jump()
    {
        JumpAn = true;
    }
    public void Right()
    {
        RightAn = true;
    }public void Left()
    {
        LeftAn = true;
    }
    public void Special()
    {
        SpecialAn = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle") && !invincible)
        {
            hit.Play();
            other.gameObject.SetActive(false);
            health -= 3;
            
        }
        else if (other.CompareTag("Obstacle2") && !invincible)
        {
            hit.Play();
            other.gameObject.SetActive(false);
            health -= 2;
            
        }
        else if (other.CompareTag("Obstacle3") && !invincible)
        {
            hit.Play();
            other.gameObject.SetActive(false);
            health -= 1;
            
        }
        else if (other.CompareTag("Health"))
        {
            other.gameObject.SetActive(false);
            if (health < 5) { 
                health += 1;
                collect.Play();
            }
            

        }
        else if (other.CompareTag("Ability"))
        {
            other.gameObject.SetActive(false);
            if (ability < 10) {
                collect.Play();
                ability += 1;
             
            }

        }
        else if (other.CompareTag("Jump"))
        {
           
            score += 3;
        }
        else if (other.CompareTag("Jump2"))
        {
           
            score += 2;
            
        }
        else if (other.CompareTag("Jump3"))
        {
            
            
            score += 1;
            
        }


    }
}

