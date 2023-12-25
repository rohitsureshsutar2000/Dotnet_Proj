namespace libBook;

public class Books{
    private string[] titles;
    public Books()
    {
        titles[0]="c++";
        titles[1]="c++";
        titles[2]="c++";
    }


    //indexer syntax
    public string this[int index]
    {
        get{return titles[index];}
        set{titles[index]=value;}
    }

}