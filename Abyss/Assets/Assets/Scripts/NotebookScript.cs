using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotebookScript : MonoBehaviour
{
    private static NoteBook playerNoteBook;
    public GameObject exitButton;
    public GameObject NextButton;
    public GameObject BackButton;

    public GameObject view;
    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        createNoteBook();

        //Load in Sprites (ask Judith how to make a resource sheet and how that is impletemented)
        //sprites = Resources.LoadAll<Sprite>("Itemsheet_6");

        Button next = NextButton.GetComponent<Button>();
        next.onClick.AddListener(turnForwardPage);

        Button back = BackButton.GetComponent<Button>();
        next.onClick.AddListener(turnBackPage);

        Button exit = exitButton.GetComponent<Button>();
        next.onClick.AddListener(ExitTaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ExitTaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        view.gameObject.SetActive(false);

    }

    public void turnBackPage()
    {
        playerNoteBook.turnPageBack();
    }

    public void turnForwardPage()
    {
        playerNoteBook.turnPageForward();
    }

    public void createNoteBook()
    {
        playerNoteBook = new NoteBook();

        noteBookPage page1 = new noteBookPage(sprites[0], 1);
        noteBookPage page2 = new noteBookPage(sprites[1], 2);
        noteBookPage page3 = new noteBookPage(sprites[2], 3);

        //playerNoteBook.addNoteBookPage(page1);
        //playerNoteBook.addNoteBookPage(page2);
        //playerNoteBook.addNoteBookPage(page3);

    }
}

public class noteBookPage
{
    private Sprite page;
    private int pageNum;
    private Boolean unlocked;

    public noteBookPage(Sprite page, int pageNum)
    {
        this.page = page;
        this.pageNum = pageNum;
        this.unlocked = false;
    }

    public Sprite getPage()
    {
        return this.page;
    }

    public int getPageNum()
    {
        return this.pageNum;
    }

    public Boolean getUnlocked()
    {
        return this.unlocked;
    }

    public void setUnlocked(Boolean unlocked)
    {
        this.unlocked = unlocked;
    }
}

public class NoteBook
{
    private List<noteBookPage> pages;
    private static noteBookPage activePage;
    private int activePageNum;
    private int numPages;

    //For loading a saved games notebook
    public NoteBook(List<noteBookPage> pages)
    {
        this.pages = pages;
        activePage = pages[0];
        activePageNum = activePage.getPageNum();
        this.numPages = pages.Count;
    }

    //For starting a new game
    public NoteBook()
    {
        this.pages = new List<noteBookPage>();
    }

    //Adds new notebook page to the notebook so that the player can see it
    //Title page is page 0 in array
    public void addNoteBookPage(int pageNum)
    {
        //page.setUnlocked(true);
        //this.pages.Add(page); //Change so that the array has all pages??
        //this.numPages++;
    }

    //Checks to see if there is another page and changes the active page to the next page
    public void turnPageForward()
    {
        activePageNum = activePage.getPageNum();
        //if(numPages > activePage) //While loop to find next unlocked page?
        //{
        //    activePage = pages[currentPage+1];
        //}
    }

    //Checks to see if there is a page before the current page and if so changes the active page to the previous page
    public void turnPageBack()
    {
        activePageNum = activePage.getPageNum();
        //int currentPage = pages.FindIndex(activePage);
        //if(currentPage != 0) //While loop to find previous unlocked page
        //{
        //    activePage = pages[currentPage - 1];
        //}
    }

    //Returns the active pages sprite
    public Sprite getActivePage()
    {
        return activePage.getPage();
    }
}
