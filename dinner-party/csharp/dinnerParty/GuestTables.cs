public class Table
{
    public string TableName { get; set; }

    public string TableOccupation { get; set;}
    // public int MaxNumberOfBooks { get; set; }
    public List<Guest> AllGuests = new List<Guest>();

    // public void AddBook(Guest singleBook)
    // {
    //     if (GuestInventory.Count < MaxNumberOfBooks)
    //     {
    //         GuestInventory.Add(singleBook);
    //     }
    //     else
    //     {
    //         Console.WriteLine("Library is full");
    //     }
    // }

            public void AddGuest(Guest singleGuest)  
        {
            AllGuests.Add(singleGuest);
        }
}

//public data = property
//private data = field