public class Contacts
{
    static int count = 1;
    int Id { get; set; }
    string Name { get; set; }
    string LastName { get; set; }
    string StreetAdress { get; set; }
    int StreetNumber { get; set; }
    int PostalNumber { get; set; }
    string PhoneNumber { get; set; }

    List<Contacts> myContacts = new();
    public Contacts(string Name, string LastName, string StreetAdress, int StreetNumber, int Postalnumber, string PhoneNumber)
    {
        this.Id = count++;
        this.Name = Name;
        this.LastName = LastName;
        this.PhoneNumber = PhoneNumber;
        this.StreetAdress = StreetAdress;
        this.StreetNumber = StreetNumber;
        this.PostalNumber = PostalNumber;
    }
    public Contacts()
    {

    }

    public void AddOneContact(Contacts item)
    {
        myContacts.Add(item);

    }
    public void ShowContacts()
    {
        foreach (Contacts item in myContacts)
        {
            System.Console.WriteLine(item.ToString());
        }

    }
    public void removeContact(int Id)
    {
        
        for (int i = 0; i < myContacts.Count; i++)
        {
            if(myContacts[i].Id == Id)
            {
                myContacts.RemoveAt(i);
            }

        }
    }
    public List<Contacts> SearchContact(string search)
    {

        foreach (Contacts item in myContacts)
        {
            if (item.Name.ToLower() == search.ToLower())
            {
                myContacts.Add(item);

            }
            else if (item.LastName.ToLower() == search.ToLower())
            {
                myContacts.Add(item);
            }
            else if (item.PhoneNumber.ToString() == search)

                myContacts.Add(item);
        }
        return myContacts;
    }

    public override string ToString()
    {
        return ($"Kontaktid: " + Id + "\nNamn: " + Name + "\nEfternamn " + LastName + "\nTelefonnummer: " + PhoneNumber + "\nGatuadress " + StreetAdress + StreetNumber + "\n  ");
    }
}


