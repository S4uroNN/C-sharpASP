namespace Lektion14.Models
{
    public class ParkingTicketMachine
    {
        public List<int> CoinsToInsert { get; set; }
        public DateTime TimeNow { get; set; }
        public DateTime PaidUntil { get; set; }
        public int AmountInserted { get; set; }

        public ParkingTicketMachine() 
        {
            AmountInserted = 0;
            TimeNow = DateTime.Now;
        }

        public void InsertCoin(int kr)
        {
            AmountInserted = kr;
            i
        }

    }
}
