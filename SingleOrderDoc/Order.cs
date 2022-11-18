// See https://aka.ms/new-console-template for more information
using Persons;
using Parsel;
using Persons.interfacePersonsAndCustomers;

Console.WriteLine("Hello, World!");

public class Order
{
    public Order(int senderOwnarId, int resiverId, int parcelId, int addressIdFrom, int addressIdTo)
    {
        SenderOwnerId = senderOwnarId;
        ReceiverId = resiverId;
        ParcelId = parcelId;
        AddressIdFrom = addressIdFrom;
        AddressIdTo = addressIdTo;
    }
    int SenderOwnerId { get; set; }
    int ReceiverId { get; set; }
    int ParcelId { get; set; }
    int AddressIdFrom { get; set; }
    int AddressIdTo { get; set; }
    int BranchId { get; set; }
    int WorkerId { get; set; }

}