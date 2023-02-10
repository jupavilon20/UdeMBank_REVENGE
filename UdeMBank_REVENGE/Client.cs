using System;
using System.Collections.Generic;

class Client
{
    
    private int client_id;
    public int Client_id
    { 
      get { return client_id; } 
      set { client_id = value; }      
    }

    private int client_balance;
    public int Client_balance
    {
        get { return client_balance; }
        set { client_balance = value; }
    }

    private string client_name;
    public string Client_name
    {
        get { return client_name; }
        set { client_name = value; }

    }

   
}