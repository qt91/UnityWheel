using UnityEngine;
using System.Collections;

public class ButtonStart : MonoBehaviour {

    public GameObject Wheel;
    private bool isRun = false;//Status wheel run
    public float Speed;//Speed wheel run

    public float TimeStatic;//Time with speed start
    private float TimeStaticCount;
    public float TimeDescending;//Time with speed Descending

    
	void Start () {

        ImageTop.OnClickedUp += AnimationClickButtonUp;
        ImageTop.OnClickedDown += AnimationClickButtonDown;
	}

    void Update()
    {
        if(isRun){// If click button start
            Vector3 vt = Vector3.up * Time.deltaTime * Speed;
            Wheel.transform.Rotate(new Vector3(0, 0, vt.y));
            if (Speed > 0)
            {
                if(TimeStaticCount < 0){
                    Speed -= TimeDescending;
                }
                else
                {
                    TimeStaticCount -= Time.deltaTime;
                }
            }
            else
            {
                Speed = 0;
                isRun = false;
            }
            
        }
    }


    void AnimationClickButtonUp()
    {
        //Control Animation Click Button Up
        gameObject.GetComponent<Animator>().SetBool("isOn", false);
    }

    void AnimationClickButtonDown()
    {
        //Control Animation Click Button Down
        //Call Animation
        gameObject.GetComponent<Animator>().SetBool("isOn", true);
        StartButtonClick();
    }

    void StartButtonClick()
    {
        isRun = true;
        Speed = 1000;
        TimeStatic = Random.Range(1, 10);
        TimeDescending = Random.Range(1, 20);
        TimeStaticCount = TimeDescending;
    }


}
