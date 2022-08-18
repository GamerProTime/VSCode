using System;
    class Calander
    {
    public int year = 2022;
    private int day = 1;
    private int month = 1;
    private string[] Months = { "Jan", "Feb", "Mar", "April", "May", "June", "July", "August", "Sept", "Oct", "Nov", "Dec"};

     public void Add(int days)
    {
        //day = day + days;
        Day = Day + days;
    }
    public int Day   // property
    {
    get { return day; }   // get method
    set { 
            if(value > 30)
            {
                int exmonth = value / 30;
                month += exmonth % 12;

                day = value % 30;
            }
                 }  // set method
    }
        
    public int Month   // property
    {
        get { return month; }   // get method
        set
        {
            if(value > 12)
            {
                month = value % 12;
                int years = value % 12;
                year += years;
            }
                
        }  
    }
        
        public override string ToString()
        {
            return "" + day + "/" + Months[month] + "/" + year;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Calander cal = new Calander();
            cal.Day = 36;
            cal.Month = 3;
            cal.year = 2022;
            Console.WriteLine(cal);
            cal.Add(500);
            Console.WriteLine(cal);
    }
    }
