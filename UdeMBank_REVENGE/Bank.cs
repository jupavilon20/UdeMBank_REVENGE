using System;
using System.Collections.Generic;

class UdeM_Bank
{
    List<Client> clients = new List<Client>();
    //List<ATM> ATMs = new List<ATM>();


    void welcome()
    {
        int option;
        Console.WriteLine("Bienvenido a UdeM Bank! \n");
        Console.WriteLine("Seleccione la opcíon que desee \n");
        Console.WriteLine("1. Retirar Dinero \n" + "2.Registros: \n");
        option = int.Parse(Console.ReadLine());
        if (option == 1) {
            return;
        }
        if (option == 2) {
            int option2;
            Console.WriteLine("Seleccione la opcíon que desee \n");
            Console.WriteLine("1. Registrar Usuario \n" + "2.Registrar ATM: \n");
            option2= int.Parse(Console.ReadLine());
            if (option2 == 1)
            {
                add_client();
            }
            if (option2 == 2) {
                return;            
            }
        }


    }

    void add_client()
    {
        Client client1 = new Client();
        Console.WriteLine("Ingrese la Identficación del cliente: \n");
        client1.Client_id = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el balance de la cuenta del cliente: \n");
        client1.Client_balance = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el balance de la cuenta del cliente: \n");
        client1.Client_name = Console.ReadLine();
        Console.WriteLine("El cliente " + client1.Client_name + " Identificado con " + client1.Client_id + " Con un balance de " + client1.Client_balance + "Ha sido registrado satisfactoriamente.\n");
    }

    public UdeM_Bank()
    {
        welcome();
    }
}
