﻿
public class Program
{
    public static void Main()
    {
        List<Guest> guests = new List<Guest>() {
            new Guest(){
                Name="Marilyn Monroe",
                Occupation="entertainer",
                Bio="(1926 - 1962) American actress, singer, model"},
            new Guest(){
                Name="Abraham Lincoln",
                Occupation="politician",
                Bio="(1809 - 1865) US President during American civil war"},
            new Guest(){
                Name="Martin Luther King",
                Occupation="activist",
                Bio="(1929 - 1968)  American civil rights campaigner"},
            new Guest(){
                Name="Rosa Parks",
                Occupation="activist",
                Bio="(1913 - 2005)  American civil rights activist"},
            new Guest(){
                Name="Peter Sellers",
                Occupation="entertainer",
                Bio="(1925 - 1980) British actor and comedian"},
            new Guest(){
                Name="Alan Turing",
                Occupation="computer scientist",
                Bio="(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"},
            new Guest(){
                Name="Admiral Grace Hopper",
                Occupation="computer scientist",
                Bio="(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"},
            new Guest(){
                Name="Indira Gandhi",
                Occupation="politician",
                Bio="(1917 - 1984) Prime Minister of India 1966 - 1977"},
        };

        List<Guest> table1 = new List<Guest>();
        List<Guest> table2 = new List<Guest>();

        List<string> occupations = new List<string>();

        foreach (Guest guest in guests)
        {
            if (occupations.Contains(guest.Occupation))
            {
                table2.Add(guest);
            }
            else
            {
                table1.Add(guest);
                occupations.Add(guest.Occupation);
            }
        }

        foreach (Guest guest in table1)
        {
            Console.WriteLine($"{guest.Name} {guest.Bio}");
        }

        Console.WriteLine();
        
        foreach (Guest guest in table2)
        {
            Console.WriteLine($"{guest.Name} {guest.Bio}");
        }




    }

}