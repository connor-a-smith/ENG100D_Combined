using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OverviewStart : MonoBehaviour {

	public GameObject speechBubble;
	public GameObject introDialogue;
	public GameObject gameDialogue;
	public GameObject checkButton;
	public GameObject schoolButton;
	public GameObject bathroomButton;
	public GameObject nextButton;
	public GameObject phoneButton;
    public GameObject loginButton;
    public GameObject scoreKeeper;
    public GameObject title;
    public GameObject background;
    public Sprite button_background;
    public Sprite avatar1;
    public Sprite avatar2;
    public Sprite avatar3;
    public GameObject avatarPic;
    public GameObject signupPage;

    public GameObject loginUser;
    public GameObject loginPass;
    public GameObject signupUser;
    public GameObject signupPass;

	public static bool dialogueControl = true;
    
	// Use this for initialization
	void Start () {
		if (OverviewStart.dialogueControl) {
            scoreKeeper.SetActive(false);
			speechBubble.SetActive (false);
			introDialogue.SetActive (false);
			gameDialogue.SetActive (false);
			nextButton.SetActive (false);
			checkButton.SetActive (false);
            schoolButton.SetActive(false);
            bathroomButton.SetActive(false);
            phoneButton.SetActive(false);
        } else {
			speechBubble.SetActive (false);
			introDialogue.SetActive (false);
			gameDialogue.SetActive (false);
			nextButton.SetActive (false);
			checkButton.GetComponent<Button> ().interactable = true;
			schoolButton.GetComponent<Button> ().interactable = true;
			bathroomButton.GetComponent<Button> ().interactable = true;
			phoneButton.GetComponent<Button> ().interactable = true;
		}
	}

	// Update is called once per frame
	void Update () {
		/*
		if (Application.platform != RuntimePlatform.Android ) {
			if (Input.GetMouseButtonDown(0)) {
				count++;
				if (dialogueControl) {
					introDialogue.SetActive (false);
					gameDialogue.SetActive (true);
				} 
				if (count == 2) {
					speechBubble.SetActive (false);
					gameDialogue.SetActive (false);
					checkButton.GetComponent<Button> ().interactable = true;
					schoolButton.GetComponent<Button> ().interactable = true;
					bathroomButton.GetComponent<Button> ().interactable = true;
					dialogueControl = false;
				}
			}
		} else {
			if (Input.touchCount >= 0 && Input.GetTouch (0).phase == TouchPhase.Began) {
				count++;
				if (dialogueControl) {
					introDialogue.SetActive (false);
					gameDialogue.SetActive (true);
				} 
				if (count == 2) {
					speechBubble.SetActive (false);
					gameDialogue.SetActive (false);
					checkButton.GetComponent<Button> ().interactable = true;
					schoolButton.GetComponent<Button> ().interactable = true;
					bathroomButton.GetComponent<Button> ().interactable = true;
					dialogueControl = false;
				}
			}
		}
		*/
	}

    public void Login() {
        title.SetActive(false);
        loginButton.SetActive(false);
        speechBubble.SetActive(true);
        introDialogue.SetActive(true);
        gameDialogue.SetActive(false);
        nextButton.SetActive(true);
        checkButton.GetComponent<Button>().interactable = false;
        schoolButton.GetComponent<Button>().interactable = false;
        bathroomButton.GetComponent<Button>().interactable = false;
        phoneButton.GetComponent<Button>().interactable = false;
        background.GetComponent<SpriteRenderer>().sprite = button_background;

        // These are the strings from the text fields
        string loginUsername = loginUser.GetComponent<InputField>().text;
        string loginPassword = loginPass.GetComponent<InputField>().text;
    }

    public void Signup() {
        loginButton.SetActive(false);
        signupPage.SetActive(true);
    }

    public void LeftPic() {
        if (avatarPic.GetComponent<Image>().sprite == avatar1)
            avatarPic.GetComponent<Image>().sprite = avatar2;
        else if (avatarPic.GetComponent<Image>().sprite == avatar2)
            avatarPic.GetComponent<Image>().sprite = avatar3;
        else
            avatarPic.GetComponent<Image>().sprite = avatar1;
    }

    public void RightPic() {
        if (avatarPic.GetComponent<Image>().sprite == avatar1)
            avatarPic.GetComponent<Image>().sprite = avatar3;
        else if (avatarPic.GetComponent<Image>().sprite == avatar2)
            avatarPic.GetComponent<Image>().sprite = avatar1;
        else
            avatarPic.GetComponent<Image>().sprite = avatar2;
    }

    public void ConfirmSignup() {
        title.SetActive(false);
        signupPage.SetActive(false);
        speechBubble.SetActive(true);
        introDialogue.SetActive(true);
        gameDialogue.SetActive(false);
        nextButton.SetActive(true);
        checkButton.GetComponent<Button>().interactable = false;
        schoolButton.GetComponent<Button>().interactable = false;
        bathroomButton.GetComponent<Button>().interactable = false;
        phoneButton.GetComponent<Button>().interactable = false;
        background.GetComponent<SpriteRenderer>().sprite = button_background;

        // These are the strings from the text fields
        string signupUsername = signupUser.GetComponent<InputField>().text;
        string signupPassword = signupPass.GetComponent<InputField>().text;
    }

    public void Next() {
		if (OverviewStart.dialogueControl) {
            scoreKeeper.SetActive(true);
			introDialogue.SetActive (false);
			gameDialogue.SetActive (true);
			checkButton.GetComponent<Button> ().interactable = true;
			schoolButton.GetComponent<Button> ().interactable = true;
			bathroomButton.GetComponent<Button> ().interactable = true;
			phoneButton.GetComponent<Button>().interactable = true;
			OverviewStart.dialogueControl = false;
			nextButton.SetActive (true);
            checkButton.SetActive(true);
            schoolButton.SetActive(true);
            bathroomButton.SetActive(true);
            phoneButton.SetActive(true);
        }
	}



}

