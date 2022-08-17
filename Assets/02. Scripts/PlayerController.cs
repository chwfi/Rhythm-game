using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class PlayerController : MonoBehaviour
{
    public Transform player;
    public float speed = 1f;
    bool angle1 = true;
    bool angle2 = false;
    public GameObject[] square;
    public bool isDestroy;
    public GameObject blow;
    bool canMove = true;
    public GameObject GameOverScreen;
    public GameObject Squares;

    public AudioSource BGM;
    private void Start()
    {
        //square = GameObject.FindGameObjectsWithTag("Square");
        BGM = gameObject.GetComponent<AudioSource>();
        StartCoroutine(PlaySong());
        StartCoroutine(End());
    }
    private IEnumerator End()
    {
        yield return new WaitForSeconds(70.9f);
        canMove = false;
    }

    public IEnumerator PlaySong()
    {
        yield return new WaitForSeconds(1.88f);
        BGM.Play();
        yield break;
    }

    void Update()
    {

        transform.Translate(Vector3.up * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && canMove == true || Input.GetMouseButtonDown(0) && canMove == true)
        {
            if (angle1 == true)
            {
                player.transform.localEulerAngles = new Vector3(0, 0, -45);               
                angle1 = false;
                angle2 = true;
            }
            else if(angle2 == true)
            {
                player.transform.localEulerAngles = new Vector3(0, 0, 45);
                angle1 = true;
                angle2 = false;
            }          
        }
        

        if (isDestroy == true)
        {
            if (Input.GetKeyDown(KeyCode.Space) && canMove == true || Input.GetMouseButtonDown(0) && canMove == true)
            {
                StartCoroutine(Destroy());
                isDestroy = false;
            }
        }
        else if (isDestroy == false)
        {
            if (Input.GetKeyDown(KeyCode.Space) && canMove == true || Input.GetMouseButtonDown(0) && canMove == true)
            {
                /*DD();
                Squares.SetActive(false);
                GameOverScreen.SetActive(true);
                Destroy(this.gameObject);*/
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Square"))
        {
            isDestroy = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Square"))
        {
            if(isDestroy == true)
            {
                /*DD();
                Squares.SetActive(false);
                GameOverScreen.SetActive(true);
                Destroy(this.gameObject);*/
            }
        }
    }

    public void DD()
    {
        GameObject.Find("Percent").GetComponent<Percentage>().Over_Loading();
    }

    private IEnumerator Destroy()
    {
        yield return new WaitForSeconds(0.01f);
        //GameOver();
        //Destroy(FindNearestObjectByTag("Square"));
        FindNearestObjectByTag("Square").SetActive(false);
    }

    public GameObject neareastEnemy;
    private GameObject FindNearestObjectByTag(string tag)
    {
        // 탐색할 오브젝트 목록을 List 로 저장합니다.
        var objects = GameObject.FindGameObjectsWithTag(tag).ToList();

        // LINQ 메소드를 이용해 가장 가까운 적을 찾습니다.
        var neareastObject = objects
            .OrderBy(obj =>
            {
                return Vector3.Distance(transform.position, obj.transform.position);
            })
        .FirstOrDefault();

        return neareastObject;
    }

}
